import { useState } from "react";
import Modal from "../Modal/Modal";
import PropType from "prop-types";

const Card = (prop) => {
  const [currentDiscount, setCurrrentDiscount] = useState("");

  return (
    <>
      <div className="w-[300px] h-[100px]">
        <div className="bg-gradient-to-br from-white  to-dark-nude text-wood text-center py-2 px-2 rounded-lg shadow-md relative">
          <h3 className="text-2xl font-semibold mb-4">
            {prop.item.percent}% Discount{" "}
          </h3>
          <div className="flex items-center space-x-2 mb-6">
            <span className="border-dashed border border-dark-nude text-darkest-brown px-4 py-2 rounded-l">
              {prop.item.code}
            </span>
            <span className="border border-white bg-white text-nude px-2 py-2 rounded-r cursor-pointer">
              Delete
            </span>
            <span
              onClick={() => {
                prop.setShowModal(true);
                console.log(prop.item);
                setCurrrentDiscount(prop.item);
              }}
              className="border border-white bg-white text-nude px-2 py-2 rounded-r cursor-pointer"
            >
              Detail
            </span>
          </div>
          <p className="text-sm">Valid Till: {prop.item.to}</p>

          <div className="w-12 h-12 bg-white rounded-full absolute top-1/2 transform -translate-y-1/2 left-0 -ml-6"></div>
          <div className="w-12 h-12 bg-white rounded-full absolute top-1/2 transform -translate-y-1/2 right-0 -mr-6"></div>
        </div>
      </div>
      <Modal
        item={currentDiscount}
        visible={prop.showModal}
        handleUpdate={prop.handleUpdate}
        onClose={() => prop.setShowModal(false)}
        setCurrrentDiscount={setCurrrentDiscount}
      ></Modal>
    </>
  );
};

Card.propTypes = {
  item: PropType.shape({
    id: PropType.number,
    code: PropType.string,
    from: PropType.string,
    to: PropType.string,
    percent: PropType.number,
  }),
  showModal: PropType.bool,
  setShowModal: PropType.func,
  handleUpdate: PropType.func,
};

export default Card;
