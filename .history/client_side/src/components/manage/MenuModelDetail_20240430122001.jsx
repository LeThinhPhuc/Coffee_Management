import React from "react";
import PropTypes from "prop-types";

const MenuModelDetail = (props) => {
    return (
        <div className="flex justify-between">
            <p className="inline-block">{props.data.item.name}</p>
            <p className="inline-block">{props.data.quantity}</p>
        </div>
    );
};

MenuModelDetail.propTypes = {
    data: PropTypes.array,
};

export default MenuModelDetail;
