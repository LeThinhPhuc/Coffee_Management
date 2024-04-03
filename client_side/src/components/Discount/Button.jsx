import PropType from "prop-types";

const Button = ({ onClick }) => {
  return (
    <button
      onClick={onClick}
      className="
    bg-dark-nude rounded-full
     h-[40px] w-[100px] font-bold mt-5
     hover:bg-nude hover:text-white
    "
    >
      Save
    </button>
  );
};

Button.propTypes = {
  onClick: PropType.func,
};

export default Button;
