import React from "react";
import TemplateDataIngredient from "./TemplateDataIngredient";
import "../styles.css";
import Manage from "../Manage";
import { useSelector } from "react-redux";
import { selectIngredients } from "../../../redux/Reducer/ingredientSlice";

const ManageIngredient = () => {
    //! Truyền data, type cho component Manage để sài chung
    const ingredients = useSelector(selectIngredients);
    console.log("ne ne");
    console.log(ingredients);
    return (
        <div>
            <Manage data={ingredients} type={"ingredient"}></Manage>;
        </div>
    );
};

export default ManageIngredient;
