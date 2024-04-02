import { useState } from "react";
import Modal from "./Modal";
import Table from "./Table";
import Card from "./Card";

const Discount = () => {
  const [showModal, setShowModal] = useState(false);

  const handleClose = () => {
    setShowModal(false);
  };

  return (
    <div className="flex-col justify-center">
      <div className="flex justify-between mb-10 items-center ">
        <div className="text-4xl text-left ">Coupons & discounts </div>
        <button
          className="bg-gradient-to-r from-nude to-dark-nude hover:from-dark-nude hover:to-nude to- px-3 py-2 mr-2 rounded-md text-white "
          onClick={() => {
            setShowModal(true);
          }}
        >
          Add Code
        </button>
      </div>
      <Card />

      <Modal visible={showModal} onClose={handleClose} />
    </div>
  );
};

export default Discount;
