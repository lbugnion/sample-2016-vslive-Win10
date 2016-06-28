using Windows.Devices.Input;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Input;

namespace CustomTriggerSample.Triggers
{
    public class InputTypeTrigger : StateTriggerBase
    {
        private PointerDeviceType _lastPointerType;
        private FrameworkElement _targetElement;

        public PointerDeviceType PointerType
        {
            get;
            set;
        }

        public FrameworkElement TargetElement
        {
            get
            {
                return _targetElement;
            }
            set
            {
                _targetElement = value;
                _targetElement.AddHandler(
                    UIElement.PointerPressedEvent,
                    new PointerEventHandler(TargetElementPointerPressed),
                    true);
            }
        }

        private void TargetElementPointerPressed(object sender, PointerRoutedEventArgs e)
        {
            _lastPointerType = e.Pointer.PointerDeviceType;
            SetActive(PointerType == _lastPointerType);
        }
    }
}