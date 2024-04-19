import PropType from "prop-types";

const Input = ({ id, label, type, placeholder, onChange, values }) => {
  return (
    <div className="mb-2">
      <p className="mb-1 text-xs font-medium sm:text-sm tracking-wide text-gray-600">
        {label}
      </p>
      <input
        id={id}
        type={type}
        placeholder={placeholder}
        value={values}
        className={`border-2 rounded-sm w-full hover:border-slate-400 active:border-nude px-2 leading-8`}
        onChange={onChange}
      />
    </div>
  );
};

Input.propTypes = {
  id: PropType.string,
  label: PropType.string,
  type: PropType.string,
  placeholder: PropType.string,
  onChange: PropType.func,
  values: PropType.string,
};

export default Input;
