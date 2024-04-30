import React from "react";

const MenuModelDetail = (props) => {
    return (
        <div className="flex justify-between">
            <p className="inline-block">{props.data.item.name}</p>
            <p className="inline-block">{props.data.item.quantity}</p>
        </div>
    );
};

export default MenuModelDetail;
