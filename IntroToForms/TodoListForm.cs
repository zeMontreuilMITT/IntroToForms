namespace IntroToForms
{
    public partial class TodoListForm : Form
    {
        private string _todoInputText;
        private string _warningLabelText;

        private List<string> _completeItems = new List<string>();
        private List<string> _incompleteItems = new List<string>();

        public TodoListForm()
        {
            InitializeComponent();
        }

        #region Events

        // private void [Element]_[EventType](object sender, EventArgs e)
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ItemInputTextBox_TextChanged(object sender, EventArgs e)
        {
            _todoInputText = ItemInputTextBox.Text;
        }

        private void ItemAddButton_Click(object sender, EventArgs e)
        {
            HandleAddItem();
        }

        private void ItemInputTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                HandleAddItem();
            }
        }

        private void TodoListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            bool willBeChecked = e.NewValue.Equals(CheckState.Checked);
            // if item is being checked, add to done list

            string itemValue = TodoListBox.Items[e.Index].ToString();

            if(willBeChecked)
            {
                _completeItems.Add(itemValue);
                _incompleteItems.Remove(itemValue);
            } else
            {
                _incompleteItems.Add(itemValue);
                _completeItems.Remove(itemValue);
            }

            RenderTodoLists();

            // if unchecked, add to not done list

            // see what the changed value is and then re-render elements
        }

        #endregion

        #region Handler Methods
        private void HandleAddItem()
        {
            if (_todoInputText.Length < 3)
            {
                _warningLabelText = "To-do items must have at least three characters in their title.";
            }
            else
            {
                _warningLabelText = "";
                _incompleteItems.Add(_todoInputText);
                ItemInputTextBox.Text = "";
                RenderTodoLists();
            }

            WarningLabel.Text = _warningLabelText;
        }

        private void RenderTodoLists()
        {
            TodoListBox.Items.Clear();
            if(_incompleteItems.Count > 0)
            {
                TodoListBox.Items.AddRange(_incompleteItems.ToArray());
            }
        }

        #endregion
    }
}