using System.Windows.Forms;
using System.Drawing.Printing;

namespace iS800
{
    public class EnhancedPrintPreviewDialog : Form
    {
        public PrintDocument Document { get; set; }

        public new DialogResult ShowDialog()
        {
            return base.ShowDialog();
        }
    }
}
