import PropType from "prop-types";

const CloseButton = ({ onClick }) => {
  return (
    <button
      onClick={onClick}
      className="rounded-full px-[10px]
           text-sm text-white 
           py-1 bg-slate-200 
           hover:bg-red-400"
    >
      X
    </button>
  );
};

CloseButton.propTypes = {
  onClick: PropType.func,
};

export default CloseButton;
