import { useState } from "react";
import PropTypes from "prop-types";

const Card = ({ item, handleDetail, handleDelete }) => {
  return (
    <div className="max-w-sm my-4">
      <div className="bg-gradient-to-br from-white to-dark-nude text-wood text-center py-4 px-6 rounded-lg shadow-md relative overflow-hidden">
        <h3 className="text-2xl font-semibold mb-4">
          {item.discountPercent}% Discount
        </h3>
        <div className="flex items-center justify-center space-x-2 mb-4">
          <span className="border-dashed border border-dark-nude text-darkest-brown px-4 py-2 rounded-l">
            {item.name}
          </span>
          <span
            onClick={() => handleDelete(item.id)}
            className="border border-white bg-white text-nude px-4 py-2 rounded-r cursor-pointer text-wood"
          >
            Delete
          </span>
          <span
            onClick={() => handleDetail(item)}
            className="border border-white bg-white text-nude px-4 py-2 rounded-r cursor-pointer text-wood"
          >
            Detail
          </span>
        </div>
        <p className="text-sm">Valid Till: {item.formattedEndDate}</p>
        <div className="w-12 h-12 bg-white rounded-full absolute top-1/2 transform -translate-y-1/2 left-0 -ml-6"></div>
        <div className="w-12 h-12 bg-white rounded-full absolute top-1/2 transform -translate-y-1/2 right-0 -mr-6"></div>
      </div>
    </div>
  );
};

Card.propTypes = {
  item: PropTypes.shape({
    id: PropTypes.string.isRequired,
    name: PropTypes.string.isRequired,
    discountPercent: PropTypes.number.isRequired,
    shopId: PropTypes.string,
    isActive: PropTypes.bool,
    startDate: PropTypes.string,
    endDate: PropTypes.string,
    formattedStartDate: PropTypes.string,
    formattedEndDate: PropTypes.string,
    dateCreated: PropTypes.string,
    dateModified: PropTypes.string,
  }).isRequired,
  handleDetail: PropTypes.func.isRequired,
  handleDelete: PropTypes.func.isRequired,
};

export default Card;
