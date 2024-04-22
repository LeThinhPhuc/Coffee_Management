import React from "react";
import TemplateDataIngredient from "./TemplateDataIngredient";
import "../styles.css";
import Manage from "../Manage";
import { useSelector } from "react-redux";
import { selectIngredients } from "../../../redux/Reducer/ingredientSlice";

const ManageIngredient = () => {
    //! Truyền data, type cho component Manage để sài chung
    const ingredients = useSelector(selectIngredients);
    const data = {
        {
            category: "Nguyên liệu",
            items: [...ingredients]
        }
        
    };

    console.log("DATA test");
    console.log(data);
    return (
        <div>
            <Manage data={data} type={"ingredient"}></Manage>;{/* Hello */}
        </div>
    );
};

export default ManageIngredient;
