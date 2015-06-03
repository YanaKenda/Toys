using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using MilitaryTechnics;
using PluginContracts;
using Toys.Adapter;
using Toys.Repository;

namespace Toys
{
    public partial class Toy : Form
    {
        private ToyCreator toyCreator;
        Label[] LabelFields;
        private ComboBox[] ComboBoxFields;
        private MainToy toy;
        private int CountProperties;
        private List<ToyCreator> ListTypes = new List<ToyCreator>();
        public ListRepository ListToys = new ListRepository();
        private List<MainToy> GetListToys = new List<MainToy>();
        private ToyEditingCreator EditingToyCreator;
        private string BsonFile = "bson.dat";
        private string pathPluginControlSum = @"E:\4 term\LABS\2 Ready\ООТПиСП\Toys\PluginControlSum\bin\Debug\PluginControlSum.dll";
        private string pathControl = @"E:\control.txt";
        BSON bson = new BSON();
        private int IndexEditingObject;
        public Toy()
        {
            InitializeComponent();
            ToyComboBox.Items.AddRange(ListToy.ListToys.ToArray());
            LabelFields = new Label[] { PropertyLabel1, PropertyLabel2, PropertyLabel3 };
            ComboBoxFields = new ComboBox[] { FieldComboBox1, FieldComboBox2, FieldComboBox3 };
            ClearFields();
        }


        private void ToyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearFields();
            FieldsForm fields = PropertyFieldsRepository.ListFields[ToyComboBox.SelectedIndex];
            ChangeFieledsOnForm(fields);

        }

        private void ChangeFieledsOnForm(FieldsForm toyFields)
        {
            CountProperties = toyFields.LabelName.Length + 3;
            for (int i = 0; i < toyFields.LabelName.Length; i++)
            {
                LabelFields[i].Text = toyFields.LabelName[i];
                LabelFields[i].Visible = true;
                for (int j = 0; j < toyFields.ComboboxName.GetLength(1); j++)
                {

                    ComboBoxFields[i].Items.Add(toyFields.ComboboxName[i, j]);
                }
                ComboBoxFields[i].Visible = true;
            }

            if (LabelFields.Length > toyFields.LabelName.Length)
            {
                for (int i = toyFields.LabelName.Length; i < LabelFields.Length; i++)
                {
                    LabelFields[i].Text = "";
                    LabelFields[i].Visible = false;
                    ComboBoxFields[i].Visible = false;
                }
            }
        }


        private void ClearFields()
        {
            ToyComboBox.Text = string.Empty;
            AgeTextBox.Text = string.Empty;
            HardLevelTextBox.Text = string.Empty;
            NameTextBox.Text = string.Empty;
            FieldComboBox1.Items.Clear();
            FieldComboBox1.Text = string.Empty;
            FieldComboBox2.Items.Clear();
            FieldComboBox2.Text = string.Empty;
            FieldComboBox3.Items.Clear();
            FieldComboBox3.Text = string.Empty;
        }

        private bool CheckPropertiesOnEmpty()
        {
            if ((NameTextBox.Text != "") && (AgeTextBox.Text != "") && (HardLevelTextBox.Text != "") && (FieldComboBox1.Text != ""))
            {
                if (CountProperties == 4)
                    return true;
                if (CountProperties == 5)
                {
                    if (FieldComboBox2.Text != "")
                        return true;
                }
                if (CountProperties == 6)
                {
                    if (FieldComboBox3.Text != "")
                        return true;
                }
            }
            return false;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            bool CanAdd = CheckPropertiesOnEmpty();
            if (CanAdd == true)
            {
                toyCreator = Creator.Creator.CurrentToy[ToyComboBox.SelectedIndex];              
                ListTypes.Add(toyCreator);
                List<string> properties = new List<string> { NameTextBox.Text, AgeTextBox.Text, HardLevelTextBox.Text, FieldComboBox1.Text, FieldComboBox2.Text, FieldComboBox3.Text };
                ListToys.List.Add(toyCreator.FactoryMethod(properties));
                listObjects.DataSource = null;
                listObjects.DataSource = ListToys.List;
                ClearFields();
            }
            else
                MessageBox.Show("Не все поля заполнены!");
        }

        private void Serialize_Click(object sender, EventArgs e)
        {
            if (ListToys.List.Count != 0)
            {
                if (Transformation.Checked == true)
                {
                    IJsonSerializationTarget adapter = new JsonSerializationAdapter(new JsonSerializationPlugin.JsonSerializationPlugin());
                    adapter.SerializeToXml(typeof(List<MainToy>), ToyTypesRepository.ListTypesToys.ToArray(), "File.xml", ListToys);
                    StreamWriter sw = new StreamWriter("File.json");
                    sw.Write(adapter.SerializeToJson("File.xml"));
                    sw.Close();
                }
                var file = File.Create(BsonFile);
                file.Close();
                for (int i = ListToys.List.Count - 1; i >= 0; i--)
                {
                    bson.Serialize(ListToys.List[i], BsonFile);
                }
                listObjects.DataSource = null;
                if (ControlSum.Checked == true)
                    SaveControlSumm();
            }
            else
                MessageBox.Show("Добавьте объект!");
        }

        public void SaveControlSumm()
        {
            PluginController controller = new PluginController();
            controller.SetFilePlugin(pathPluginControlSum);
            ICollection<IControlSum> plugins = controller.LoadAssembleys<IControlSum>(typeof(IControlSum));
            foreach (var item in plugins)
            {
                string sum = item.SumFile(BsonFile);
                string pathFileSum = pathControl;
                File.WriteAllText(pathFileSum, sum);
            }
        }

        public void Deserialize_Click(object sender, EventArgs e)
        {
            if (ControlSum.Checked == true)
            {
                if (CheckFile())
                    Deserializefunc();
                else
                    MessageBox.Show("Контрольная сумма не совпадает!");
            }
            else
                Deserializefunc();
        }

        public void Deserializefunc()
        {
            GetListToys = bson.Deserialize(BsonFile, ListTypes);
            listObjects.DataSource = GetListToys;
        }

        public bool CheckFile()
        {
            string savedSum = ReadSumFromFile();
            string sumFile = string.Empty;
            PluginController controller = new PluginController();
            controller.SetFilePlugin(pathPluginControlSum);
            ICollection<IControlSum> plugins = controller.LoadAssembleys<IControlSum>(typeof(IControlSum));
            foreach (var item in plugins)
            {
                sumFile = item.SumFile(BsonFile);
            }
            if (sumFile == savedSum)
                return true;
            return false;
        }

        public string ReadSumFromFile()
        {
            FileStream stream = new FileStream(pathControl, FileMode.Open);
            StreamReader reader = new StreamReader(stream);
            string returnvalue = reader.ReadLine();
            reader.Close();
            stream.Close();
            return returnvalue;
        }


        private void FillFields(List<string> properties)
        {
            NameTextBox.Text = properties[0];
            HardLevelTextBox.Text = properties[1];
            AgeTextBox.Text = properties[2];
            for (int i = 0; i < properties.Count - 3; i++)
            {
                ComboBoxFields[i].Text = properties[3 + i];
            }
        }
        private int GetIndexInList(MainToy technic)
        {
            int countTypes = ListToy.ListToys.Count;
            for (int i = 0; i < countTypes; i++)
            {
                string type = "Toy:" + ListToy.ListToys[i].ToString();
                string Info = technic.GetInfo();
                if (Info.Contains(type))
                    return i;
            }
            return -1;
        }

        private void change_Click(object sender, EventArgs e)
        {
            save.Visible = true;
            AddButton.Visible = false;
            List<string> properties = new List<string>();
            toy = (MainToy)listObjects.SelectedItem;
            int index = GetIndexInList(toy);
            ToyComboBox.SelectedIndex = index;
            EditingToyCreator = EditingCreatorRepository.GetListEditingToy[ToyComboBox.SelectedIndex];
            EditingToyCreator.FactoryMethod(toy, properties);
            FieldsForm Property = PropertyFieldsRepository.ListFields[ToyComboBox.SelectedIndex];
            ChangeFieledsOnForm(Property);
            FillFields(properties);
            ListToys.List.RemoveAt(listObjects.SelectedIndex);
            IndexEditingObject = listObjects.SelectedIndex;
        }


        private void Plugin_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = openFileDialog.FileName;
                PluginController controller = new PluginController();
                controller.SetFilePlugin(file);
                ICollection<INewToyPlugin> plugins = controller.LoadAssembleys<INewToyPlugin>(typeof(INewToyPlugin));
                foreach (var item in plugins)
                {
                    ListToy.ListToys.Add(item.NameToy);
                    ToyComboBox.Items.Clear();
                    ToyComboBox.Items.AddRange(ListToy.ListToys.ToArray());
                    PropertyFieldsRepository.ListFields.Add(item.Fields);
                    Creator.Creator.CurrentToy.Add(item.ToyCreator);
                    EditingCreatorRepository.GetListEditingToy.Add(item.ToyEditingCreator);
                }
            }

        }


        private void Transformation_CheckedChanged(object sender, EventArgs e)
        {

        }

    }
}
