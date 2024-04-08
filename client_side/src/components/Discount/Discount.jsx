import { useState } from "react";
import Modal from "./Modal/Modal";
import Card from "./Card/Card";

const Discount = () => {
  const [showModal, setShowModal] = useState(false);
  const [lastId, setLastId] = useState(0);

  const handleClose = () => {
    setShowModal(false);
  };

  const handleOpen = () => {
    setShowModal(true);
  };

  const handleAdd = (newDiscount) => {
    setLastId(discountArr.length + 1);
    const discountWithId = { ...newDiscount, id: lastId };
    setDiscountArr([...discountArr, discountWithId]);
  };

  const handleUpdate = (updatedDiscount) => {
    //update the discountArr with the updatedDiscount
    const updateDiscountArr = discountArr.map((discount) =>
      discount.id === updatedDiscount.id ? updatedDiscount : discount
    );
    setDiscountArr(updateDiscountArr);
    setShowModal(false);
  };

  const [discountArr, setDiscountArr] = useState([
    {
      id: 1,
      code: "CHRISMAS20",
      start: "10/04/2024",
      end: "10/5/2024",
      percent: 20,
    },
    {
      id: 2,
      code: "CHRISMAS20",
      start: "10/04/2024",
      end: "10/5/2024",
      percent: 20,
    },
    {
      id: 3,
      code: "CHRISMAS20",
      start: "10/04/2024",
      end: "10/5/2024",
      percent: 20,
    },
  ]);

  return (
    <div className="flex-col justify-center py-16 px-10">
      <div className="flex justify-between mb-10 items-center ">
        <div className="text-4xl text-left ">Coupons & discounts </div>
        <button
          className="bg-gradient-to-r from-nude to-dark-nude hover:from-dark-nude hover:to-nude to- px-3 py-2 mr-2 rounded-md text-white "
          onClick={handleOpen}
        >
          Add Code
        </button>
      </div>
      <div className="flex space-x-6">
        {discountArr.map((discount) => (
          <Card
            key={discount.id}
            item={discount}
            showModal={showModal}
            setShowModal={setShowModal}
            handleUpdate={handleUpdate}
          />
        ))}
      </div>
      <Modal
        visible={showModal}
        onClose={handleClose}
        setShowModal={setShowModal}
        handleAdd={handleAdd}
      />
    </div>
  );
};

export default Discount;
