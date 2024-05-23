import React, { createContext, useState } from "react";

// Tạo Context
export const MenuContext = createContext();

// Component cung cấp Context
export const AppProvider = ({ children }) => {
    const [selectedDrink, setSelectedDrink] = useState([]);
    const [checkModalVoucher,setModalVoucher]=useState(false)
    const [voucherValue,setVoucherValue]=useState()

    const addSelectedDrink = (newSelected) => {
        setSelectedDrink([...selectedDrink, {drinkId:newSelected.id, quantity:1, price:newSelected.price, name:newSelected.name, imagePath:newSelected.image, note:""}]);
    };

    const deleteOutSelected = (deleteSelected)=>{
        const updatedSelectedDrink = selectedDrink.filter((item) => item.drinkId !== deleteSelected.id);
            setSelectedDrink(updatedSelectedDrink);
    }
    const deleteOutSelectedOnOrder = (deleteSelected)=>{
        const updatedSelectedDrink = selectedDrink.filter((item) => item.drinkId !== deleteSelected.drinkId);
            setSelectedDrink(updatedSelectedDrink);
    }
    const clearSelected = () =>{
        setSelectedDrink([]);
    }
    return (
        <MenuContext.Provider
            value={{
                selectedDrink: selectedDrink, // Chỉnh sửa thành selectedDrink
                setSelectedDrink:setSelectedDrink,
                addSelectedDrink: addSelectedDrink, // Thêm hàm addSelectedDrink vào context
                deleteOutSelected:deleteOutSelected,
                deleteOutSelectedOnOrder:deleteOutSelectedOnOrder,
                clearSelected:clearSelected,
                checkModalVoucher:checkModalVoucher,
                setModalVoucher:setModalVoucher,
                voucherValue:voucherValue,
                setVoucherValue:setVoucherValue,
            }}
        >
            {children}
        </MenuContext.Provider>
    );
};
