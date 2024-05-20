// Coffee_Management/client_side/src/components/Voucher.jsx
import { useEffect, useState } from 'react';
import { connect } from 'react-redux';
import PropTypes from 'prop-types';
import {
  fetchVouchers,
  addVoucher,
  updateVoucher,
  deleteVoucher
} from '../../redux/Action/voucherAction';

const Voucher = ({ vouchers, fetchVouchers, addVoucher, updateVoucher, deleteVoucher }) => {
  useEffect(() => {
    fetchVouchers();
  }, []);

  const [showModal, setShowModal] = useState(false);
  const [editMode, setEditMode] = useState(false);
  const [currentVoucher, setCurrentVoucher] = useState({
    id: '',
    name: '',
    discount: 0,
    expirationDate: ''
  });

  const handleDelete = (id) => {
    deleteVoucher(id)
      .then(() => {
        fetchVouchers();
      })
      .catch((error) => {
        console.error('Error deleting voucher:', error);
      });
  };

  const handleSubmit = (e) => {
    e.preventDefault();
    if (editMode) {
      updateVoucher(currentVoucher)
        .then(() => {
          setShowModal(false);
          setEditMode(false);
          fetchVouchers();
        })
        .catch((error) => {
          console.error('Error updating voucher:', error);
        });
    } else {
      addVoucher(currentVoucher)
        .then(() => {
          setShowModal(false);
          fetchVouchers();
        })
        .catch((error) => {
          console.error('Error adding voucher:', error);
        });
    }
    setCurrentVoucher({
      id: '',
      name: '',
      discount: 0,
      expirationDate: ''
    });
  };

  const handleEdit = (voucher) => {
    setCurrentVoucher(voucher);
    setEditMode(true);
    setShowModal(true);
  };

  return (
    <div className="container mx-auto">
      <h1 className="text-2xl font-bold mb-4">Vouchers</h1>

      {showModal && (
        <div className="fixed inset-0 z-10 overflow-y-auto">
          <div className="flex items-center justify-center min-h-screen">
            <div className="fixed inset-0 transition-opacity" aria-hidden="true">
              <div className="absolute inset-0 bg-gray-500 opacity-75"></div>
            </div>
            <div className="relative z-10 bg-white rounded-lg px-4 pt-5 pb-4 overflow-hidden shadow-xl sm:max-w-sm sm:w-full sm:p-6">
              <div className="absolute top-0 right-0 pt-2 pr-4">
                <button
                  onClick={() => {
                    setShowModal(false);
                    setEditMode(false);
                    setCurrentVoucher({ id: '', name: '', discount: 0, expirationDate: '' });
                  }}
                  className="text-gray-400 hover:text-gray-500 focus:outline-none focus:text-gray-500 transition ease-in-out duration-150"
                >
                  <span className="sr-only">Close</span>
                  <svg className="h-6 w-6" stroke="currentColor" fill="none" viewBox="0 0 24 24">
                    <path strokeLinecap="round" strokeLinejoin="round" strokeWidth="2" d="M6 18L18 6M6 6l12 12"></path>
                  </svg>
                </button>
              </div>
              <div>
                <h3 className="text-lg leading-6 font-medium text-gray-900">{editMode ? 'Edit Voucher' : 'Add Voucher'}</h3>
                <div className="mt-2">
                  <div className="mt-1 rounded-md shadow-sm">
                    <input
                      type="text"
                      name="name"
                      id="name"
                      className="block w-full border-gray-300 rounded-md focus:ring-indigo-500 focus:border-indigo-500 sm:text-sm"
                      placeholder="Name"
                      value={currentVoucher.name}
                      onChange={(e) => setCurrentVoucher({ ...currentVoucher, name: e.target.value })}
                    />
                  </div>
                  <div className="mt-1 rounded-md shadow-sm">
                    <input
                      type="number"
                      name="discount"
                      id="discount"
                      className="block w-full border-gray-300 rounded-md focus:ring-indigo-500 focus:border-indigo-500 sm:text-sm"
                      placeholder="Discount"
                      value={currentVoucher.discount}
                      onChange={(e) => setCurrentVoucher({ ...currentVoucher, discount: parseFloat(e.target.value) })}
                    />
                  </div>
                  <div className="mt-1 rounded-md shadow-sm">
                    <input
                      type="date"
                      name="expirationDate"
                      id="expirationDate"
                      className="block w-full border-gray-300 rounded-md focus:ring-indigo-500 focus:border-indigo-500 sm:text-sm"
                      placeholder="Expiration Date"
                      value={currentVoucher.expirationDate}
                      onChange={(e) => setCurrentVoucher({ ...currentVoucher, expirationDate: e.target.value })}
                    />
                  </div>
                </div>
              </div>
              <div className="mt-5 sm:mt-6">
                <button
                  onClick={handleSubmit}
                  type="button"
                  className="inline-flex justify-center w-full rounded-md border border-transparent shadow-sm px-4 py-2 bg-indigo-600 text-base leading-6 font-medium text-white hover:bg-indigo-500 focus:outline-none focus:border-indigo-700 focus:shadow-outline-indigo transition ease-in-out duration-150 sm:text-sm sm:leading-5"
                >
                  {editMode ? 'Update' : 'Add'}
                </button>
              </div>
            </div>
          </div>
        </div>
      )}

      <div className="grid grid-cols-1 gap-6 sm:grid-cols-2 md:grid-cols-3 lg:grid-cols-4">
        {vouchers.map((voucher) => (
          <div key={voucher.id} className="bg-white p-4 rounded-lg shadow-md">
            <h2 className="text-xl font-bold mb-2">{voucher.name}</h2>
            <p className="text-gray-700 mb-2">Discount: {voucher.discount}%</p>
            <p className="text-gray-700 mb-2">Expiration Date: {voucher.expirationDate}</p>
            <div className="flex justify-between">
              <button
                onClick={() => handleEdit(voucher)}
                className="bg-blue-500 text-white px-3 py-1 rounded-md"
              >
                Edit
              </button>
              <button
                onClick={() => handleDelete(voucher.id)}
                className="bg-red-500 text-white px-3 py-1 rounded-md"
              >
                Delete
              </button>
            </div>
          </div>
        ))}
      </div>
    </div>
  );
};

Voucher.propTypes = {
  vouchers: PropTypes.array.isRequired,
  fetchVouchers: PropTypes.func.isRequired,
  addVoucher: PropTypes.func.isRequired,
  updateVoucher: PropTypes.func.isRequired,
  deleteVoucher: PropTypes.func.isRequired,
};

const mapStateToProps = (state) => ({
  vouchers: state.voucher.vouchers
});

const mapDispatchToProps = {
  fetchVouchers,
  addVoucher,
  updateVoucher,
  deleteVoucher
};

export default connect(mapStateToProps, mapDispatchToProps)(Voucher);
