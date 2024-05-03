import React from "react";
import PropTypes from "prop-types";

const MenuModelDetail = (props) => {
    return (
        <div className="flex justify-between">
            <p className="inline-block">
                {props.data.item.name} - {props.data.quantity}
            </p>
            <p className="inline-block"></p>
        </div>
    );
};

MenuModelDetail.propTypes = {
    data: PropTypes.object,
};

export default MenuModelDetail;
