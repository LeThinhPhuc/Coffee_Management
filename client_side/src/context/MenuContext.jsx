import React, { createContext, useState } from "react";

// Tạo Context
export const MenuContext = createContext();

// Component cung cấp Context
export const AppProvider = ({ children }) => {
    const [selectedDrink, setSelectedDrink] = useState([]);

    const addSelectedDrink = (newSelected) => {
        setSelectedDrink([...selectedDrink, newSelected]);
    };

    const deleteOutSelected = (deleteSelected)=>{
        const updatedSelectedDrink = selectedDrink.filter((item) => item.id !== deleteSelected.id);
            setSelectedDrink(updatedSelectedDrink);
    }

    return (
        <MenuContext.Provider
            value={{
                selectedDrink: selectedDrink, // Chỉnh sửa thành selectedDrink
                addSelectedDrink: addSelectedDrink, // Thêm hàm addSelectedDrink vào context
                deleteOutSelected:deleteOutSelected
            }}
        >
            {children}
        </MenuContext.Provider>
    );
};
