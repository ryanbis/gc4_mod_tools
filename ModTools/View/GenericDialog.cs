using ModTools.View.Contracts;

namespace ModTools.View;

public class GenericDialog : IGenericDialogView
{
    public DialogResult Show_Ok(string messageText, string title)
    {
        return MessageBox.Show(messageText, title, MessageBoxButtons.OK);
    }

    public DialogResult Show_YesNo(string messageText, string title)
    {
        return MessageBox.Show(messageText, title, MessageBoxButtons.YesNo);
    }
}