import PropType from "prop-types";
import Input from "./Input";
import Button from "./Button";
import CloseButton from "./CloseButton";

const Modal = ({ visible, onClose }) => {
  if (!visible) return null;

  return (
    <div
      className=" fixed bg-black 
     inset-0 bg-opacity-30 backdrop-blur-sm
      flex justify-center items-center"
    >
      <div
        className="bg-white w-10/12 lg:w-6/12
        h-4/6 z-auto rounded-2xl mt-10
        p-2.5 drop-shadow-2xl "
      >
        <div className="flex justify-between align-middle px-5 my-3">
          <h3 className="font-medium font-montserrat"> New Discount Coupon</h3>

          <CloseButton onClick={onClose}></CloseButton>
        </div>
        <div className="mt-6 px-7 text-sm text-left">
          <Input label="Coupon Code" type="text" />
          <Input label="From" type="date"></Input>
          <Input label="To" type="date"></Input>
          <Input label="Percent" type="number"></Input>
        </div>
        <Button onClick={onClose} />
      </div>
    </div>
  );
};

Modal.propTypes = {
  visible: PropType.bool,
  onClose: PropType.func,
};

export default Modal;
