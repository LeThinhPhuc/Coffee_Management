// Coffee_Management/client_side/src/components/Discount/Discount.jsx
import { useState, useEffect } from "react";
import { connect } from "react-redux";
import PropTypes from "prop-types";
import Modal from "./Modal/Modal";
import Card from "./Card/Card";
import {
  fetchVouchers,
  addVoucher,
  updateVoucher,
  deleteVoucher,
} from "../../redux/Action/voucherAction";
import { ToastContainer, toast } from "react-toastify";
import "react-toastify/dist/ReactToastify.css";

const Discount = ({
  vouchers,
  fetchVouchers,
  addVoucher,
  updateVoucher,
  deleteVoucher,
}) => {
  const [showModal, setShowModal] = useState(false);
  const [currentDiscount, setCurrentDiscount] = useState(null);

  useEffect(() => {
    fetchVouchers(); // Initial fetch when component mounts
  }, [fetchVouchers]);

  const handleClose = () => {
    setShowModal(false);
    setCurrentDiscount(null);
  };

  const handleOpen = () => {
    setShowModal(true);
  };

  const handleAdd = async (newDiscount) => {
    // Call addVoucher action which should handle the API call to add the voucher
    addVoucher(newDiscount)
      .then(() => {
        setShowModal(false);
        fetchVouchers();
      })
      .catch((error) => {
        console.error("Error adding voucher:", error);
      });
  };

  const handleUpdate = (updatedDiscount) => {
    // Call addVoucher action which should handle the API call to add the voucher
    updateVoucher(updatedDiscount)
      .then(() => {
        setShowModal(false);
        fetchVouchers();
      })
      .catch((error) => {
        console.error("Error updating voucher:", error);
      });
    setShowModal(false);
  };

  const handleDelete = (id) => {
    deleteVoucher(id);
  };

  return (
    <div className="flex-col justify-center py-16 px-10">
      <ToastContainer />
      <div className="flex justify-between mb-10 items-center">
        <div className="text-4xl text-left">Coupons & Discounts</div>
        <button
          className="bg-gradient-to-r from-nude to-dark-nude hover:from-dark-nude hover:to-nude px-3 py-2 mr-2 rounded-md text-white"
          onClick={handleOpen}
        >
          Add Code
        </button>
      </div>
      <div className="flex space-x-6">
        {vouchers.map((discount) => (
          <Card
            key={discount.id}
            item={discount}
            showModal={showModal}
            setShowModal={setShowModal}
            handleUpdate={handleUpdate}
            handleDelete={handleDelete}
          />
        ))}
      </div>
      
      {setCurrentDiscount ? (
        <Modal
        item={currentDiscount}
        visible={showModal}
        onClose={handleClose}
        handleAdd={handleAdd}
        handleUpdate={handleUpdate}
        setCurrentDiscount={setCurrentDiscount}
      />
      ) : (
        <p>Loading...</p> // Placeholder while fetching or if not logged in
      )}
    </div>
  );
};

Discount.propTypes = {
  vouchers: PropTypes.array.isRequired,
  fetchVouchers: PropTypes.func.isRequired,
  addVoucher: PropTypes.func.isRequired,
  updateVoucher: PropTypes.func.isRequired,
  deleteVoucher: PropTypes.func.isRequired,
};

const mapStateToProps = (state) => ({
  vouchers: state.voucher.vouchers,
});

const mapDispatchToProps = {
  fetchVouchers,
  addVoucher,
  updateVoucher,
  deleteVoucher,
};

export default connect(mapStateToProps, mapDispatchToProps)(Discount);
