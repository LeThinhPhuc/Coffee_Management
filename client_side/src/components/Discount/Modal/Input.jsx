// Coffee_Management/client_side/src/components/Discount/Modal/Input.jsx
import PropTypes from "prop-types";

const Input = ({ id, label, type, value, onChange, placeholder, disabled }) => (
  <div className="flex flex-col mb-4">
    <label htmlFor={id} className="mb-2 text-sm text-gray-600">
      {label}
    </label>
    <input
      id={id}
      type={type}
      value={value}
      onChange={onChange}
      placeholder={placeholder}
      disabled={disabled}
      className="p-2 border border-gray-300 rounded"
    />
  </div>
);

Input.propTypes = {
  id: PropTypes.string.isRequired,
  label: PropTypes.string.isRequired,
  type: PropTypes.string.isRequired,
  value: PropTypes.oneOfType([PropTypes.string, PropTypes.number]).isRequired,
  onChange: PropTypes.func.isRequired,
  placeholder: PropTypes.string,
  disabled: PropTypes.bool,
};

Input.defaultProps = {
  placeholder: "",
  disabled: false,
};

export default Input;
