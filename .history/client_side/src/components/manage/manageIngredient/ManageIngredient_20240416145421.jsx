import React from "react";
import TemplateDataIngredient from "./TemplateDataIngredient";
import Manage from "../Manage";

const ManageIngredient = () => {
    //! Truyền data, type cho component Manage để sài chung
    return (
        <div>
            <Manage data={TemplateDataIngredient} type={"ingredient"}></Manage>;
        </div>
    );
};

export default ManageIngredient;
