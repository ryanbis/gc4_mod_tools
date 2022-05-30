namespace ModTools.View.Contracts;

public interface IGenericDialogView
{
    DialogResult Show_Ok(string messageText, string title);
    DialogResult Show_YesNo(string messageText, string title);
}