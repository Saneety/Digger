using UnityEngine;
using UnityEngine.UI;

namespace Digger
{
    public class UIController : MonoBehaviour
    {
        [SerializeField] private Image[] _formIconsBack;
        [SerializeField] private Color _selectedColor = Color.cyan;

        private Image _currentIcon;

        public void UpdateFormUI(int val)
        {
            if(_currentIcon != null)
                _currentIcon.color = Color.white;
            _currentIcon = _formIconsBack[val];
            _currentIcon.color =_selectedColor;
        }
    }
}
