
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Practice.Model
{
    public class Button
    {
        // Delegate for the OnClick event
        public delegate void ClickHandler();
        // Event based on the delegate
        public event ClickHandler OnClick;
        // Method to simulate button click
        public void Click()
        {
            // Trigger the event if there are any subscribers
            OnClick?.Invoke();
        }
    }
}



