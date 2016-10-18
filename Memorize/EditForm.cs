using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memorize
{
    public enum EditMode
    {
        Append,
        Update
    }

    public partial class EditForm : Form
    {
        public EditForm()
        {
            InitializeComponent();
            Init();
        }

        public EditMode Mode { get { return editMode; } }

        public void SetEditMode(EditMode mode)
        {
            editMode = mode;
            if (editMode == EditMode.Append)
            {
                this.lbHeader.Text = "Добавление";
                return;
            }
            if (editMode == EditMode.Update)
            {
                this.lbHeader.Text = "Редактирование";
                return;
            }
        }

        private void Init()
        {
            pnlWorkArea.Dock = DockStyle.Fill;
        }

        private EditMode editMode;
    }
}
