// NavigationManager.cs
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Uygulama001
{
    public static class NavigationManager
    {
        private static Stack<Form> formStack = new Stack<Form>();

        public static void NavigateTo(Form form)
        {
            if (formStack.Count > 0)
                formStack.Peek().Hide();

            formStack.Push(form);
            form.FormClosed += (sender, e) => formStack.Pop();
            form.Show();
        }

        public static void GoBack()
        {
            if (formStack.Count > 1)
            {
                Form currentForm = formStack.Pop();
                currentForm.Hide();
                Form previousForm = formStack.Peek();
                previousForm.Show();
            }
        }
    }
}