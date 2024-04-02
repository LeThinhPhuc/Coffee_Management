import PropType from "prop-types";

const Input = ({ label, type }) => {
  return (
    <div className="mb-2">
      <p className="mb-2 ">{label}</p>
      <input
        type={type}
        className={`border-2 rounded-sm ${type === "date" ? "w-6/12" : "w-full"}
               hover:border-slate-400 active:border-nude
               px-2 leading-8`}
      />
    </div>
  );
};

Input.propTypes = {
  label: PropType.string,
  type: PropType.string,
};

export default Input;
