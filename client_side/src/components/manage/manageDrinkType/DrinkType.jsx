// components/DrinkTypes.jsx
import React, { useEffect, useState } from "react";
import { connect } from "react-redux";
import PropTypes from "prop-types";
import { fetchDrinkTypes } from "../../../redux/Action/drinkTypeActions";
import typeService from "../../../services/typeService";

const DrinkTypes = ({ drinkTypes, fetchDrinkTypes, deleteDrinkType }) => {
  useEffect(() => {
    fetchDrinkTypes();
  }, []);

  const [showModal, setShowModal] = useState(false);
  const [newDrinkType, setNewDrinkType] = useState({
    name: "",
    shopId: "",
  });

  const handleDelete = async (id) => {  
      try {
        // call service
        await typeService.deleteDrinkType(id)
  
        fetchDrinkTypes(); // Refresh drink types after addition
        
      } catch (error) {
        console.error("Error deleting drink type:", error);
      }
  };

  const handleAddDrinkType = async (e) => {
    e.preventDefault();
    try {
      // Get the shop ID from the first shop in the array of shops
      const { shops } = JSON.parse(localStorage.getItem("user"));
      const shopId = shops[0].id;


      // Get the user obj from the first shop in the array of shops
    const { accessToken } = JSON.parse(localStorage.getItem("user"));
    const currentUserAccessToken = accessToken;
      console.log('accessToken:', currentUserAccessToken);

      // Add the shop ID to the drink type data
      const dataWithShopId = { ...newDrinkType, shopId }; // Combine newDrinkType with shopId
    
      // call service
      await typeService.addDrinkType(dataWithShopId);

      setShowModal(false);
      fetchDrinkTypes(); // Refresh drink types after addition
      // Reset new drink type form
      setNewDrinkType({
        name: "",
        shopId: "",
      });
    } catch (error) {
      console.error("Error adding drink type:", error);
    }
  };

  return (
    <div className="container mx-auto">
      <h1 className="text-2xl font-bold mb-4">Drink Types</h1>

      {/* Add Drink Type Modal */}
      {showModal && (
        <div className="fixed inset-0 z-10 overflow-y-auto">
          <div className="flex items-center justify-center min-h-screen">
            <div
              className="fixed inset-0 transition-opacity"
              aria-hidden="true"
            >
              <div className="absolute inset-0 bg-gray-500 opacity-75"></div>
            </div>
            <div className="relative z-10 bg-white rounded-lg px-4 pt-5 pb-4 overflow-hidden shadow-xl sm:max-w-sm sm:w-full sm:p-6">
              <div className="absolute top-0 right-0 pt-2 pr-4">
                <button
                  onClick={() => setShowModal(false)}
                  className="text-gray-400 hover:text-gray-500 focus:outline-none focus:text-gray-500 transition ease-in-out duration-150"
                >
                  <span className="sr-only">Close</span>
                  <svg
                    className="h-6 w-6"
                    stroke="currentColor"
                    fill="none"
                    viewBox="0 0 24 24"
                  >
                    <path
                      strokeLinecap="round"
                      strokeLinejoin="round"
                      strokeWidth="2"
                      d="M6 18L18 6M6 6l12 12"
                    ></path>
                  </svg>
                </button>
              </div>
              <div>
                <h3 className="text-lg leading-6 font-medium text-gray-900">
                  Add Drink Type
                </h3>
                <div className="mt-2">
                  <div className="mt-1 rounded-md shadow-sm">
                    <input
                      type="text"
                      name="name"
                      id="name"
                      className="block w-full border-gray-300 rounded-md focus:ring-indigo-500 focus:border-indigo-500 sm:text-sm"
                      placeholder="Name"
                      value={newDrinkType.name}
                      onChange={(e) =>
                        setNewDrinkType({
                          ...newDrinkType,
                          name: e.target.value,
                        })
                      }
                    />
                  </div>
                  {/* <div className="mt-1 rounded-md shadow-sm">
                    <input
                      type="text"
                      name="shopId"
                      id="shopId"
                      className="block w-full border-gray-300 rounded-md focus:ring-indigo-500 focus:border-indigo-500 sm:text-sm"
                      placeholder="Shop ID"
                      value={newDrinkType.shopId}
                      onChange={(e) => setNewDrinkType({ ...newDrinkType, shopId: e.target.value })}
                    />
                  </div> */}
                </div>
              </div>
              <div className="mt-5 sm:mt-6">
                <button
                  onClick={handleAddDrinkType}
                  type="button"
                  className="inline-flex justify-center w-full rounded-md border border-transparent shadow-sm px-4 py-2 bg-indigo-600 text-base leading-6 font-medium text-white hover:bg-indigo-500 focus:outline-none focus:border-indigo-700 focus:shadow-outline-indigo transition ease-in-out duration-150 sm:text-sm sm:leading-5"
                >
                  Add
                </button>
              </div>
            </div>
          </div>
        </div>
      )}

      {/* Drink Type List */}
      <div className="grid grid-cols-1 gap-6 sm:grid-cols-2 md:grid-cols-3 lg:grid-cols-4">
        {drinkTypes.data.map((drinkType) => (
          <div
            key={drinkType.id}
            className="rounded-lg bg-white overflow-hidden shadow-md"
          >
            <div className="px-4 py-5 sm:px-6">
              <h3 className="text-lg leading-6 font-medium text-gray-900">
                {drinkType.name}
              </h3>
              <p className="mt-1 max-w-2xl text-sm text-gray-500">
                {drinkType.shopId}
              </p>
            </div>
            <div className="px-4 py-4 sm:px-6">
              <button
                onClick={() => handleDelete(drinkType.id)}
                className="inline-flex justify-center w-full rounded-md border border-transparent px-4 py-2 bg-red-600 text-base leading-6 font-medium text-white hover:bg-red-500 focus:outline-none focus:border-red-700 focus:shadow-outline-indigo transition ease-in-out duration-150 sm:text-sm sm:leading-5"
              >
                Delete
              </button>
            </div>
          </div>
        ))}
      </div>

      {/* Add Drink Type Button */}
      <div className="mt-6">
        <button
          onClick={() => setShowModal(true)}
          className="inline-flex justify-center w-full rounded-md border border-transparent px-4 py-2 bg-green-600 text-base leading-6 font-medium text-white hover:bg-green-500 focus:outline-none focus:border-green-700 focus:shadow-outline-indigo transition ease-in-out duration-150 sm:text-sm sm:leading-5"
        >
          Add Drink Type
        </button>
      </div>
    </div>
  );
};

DrinkTypes.propTypes = {
  drinkTypes: PropTypes.shape({
    loading: PropTypes.bool,
    data: PropTypes.arrayOf(
      PropTypes.shape({
        id: PropTypes.string,
        name: PropTypes.string,
        shopId: PropTypes.string,
      })
    ),
    error: PropTypes.string,
  }).isRequired,
  fetchDrinkTypes: PropTypes.func.isRequired,
  deleteDrinkType: PropTypes.func.isRequired,
};

const mapStateToProps = (state) => {
  return {
    drinkTypes: state.drinkTypes,
  };
};

const mapDispatchToProps = (dispatch) => {
  return {
    fetchDrinkTypes: () => dispatch(fetchDrinkTypes()),
  };
};

export default connect(mapStateToProps, mapDispatchToProps)(DrinkTypes);
