using Microsoft.Xna.Framework.Input;
namespace Keika
{

    public class InputHandler
    {
        private KeyboardState _currentKeyboardState;
        private KeyboardState _previousKeyboardState;

        public InputHandler()
        {
            _currentKeyboardState = Keyboard.GetState();
            _previousKeyboardState = _currentKeyboardState;
        }

        public void Update()
        {
            _previousKeyboardState = _currentKeyboardState;
            _currentKeyboardState = Keyboard.GetState();
        }

        public bool IsKeyPressed(Keys key)
        {
            return _currentKeyboardState.IsKeyDown(key) && _previousKeyboardState.IsKeyUp(key);
        }
    }
}