import React, { createContext, useState } from "react";

// Tạo Context
export const MenuContext = createContext();

// Component cung cấp Context
export const AppProvider = ({ children }) => {
    const [selectedDrink, setSelectedDrink] = useState([]);
    const [checkModalVoucher,setModalVoucher]=useState(false)
    const [voucherValue,setVoucherValue]=useState()

    const addSelectedDrink = (newSelected) => {
        setSelectedDrink([...selectedDrink, {id:newSelected.id, quantity:1, price:newSelected.price, name:newSelected.name, imagePath:newSelected.image}]);
    };

    const deleteOutSelected = (deleteSelected)=>{
        const updatedSelectedDrink = selectedDrink.filter((item) => item.id !== deleteSelected.id);
            setSelectedDrink(updatedSelectedDrink);
    }
   
    return (
        <MenuContext.Provider
            value={{
                selectedDrink: selectedDrink, // Chỉnh sửa thành selectedDrink
                setSelectedDrink:setSelectedDrink,
                addSelectedDrink: addSelectedDrink, // Thêm hàm addSelectedDrink vào context
                deleteOutSelected:deleteOutSelected,
                checkModalVoucher:checkModalVoucher,
                setModalVoucher:setModalVoucher,
                voucherValue:voucherValue,
                setVoucherValue:setVoucherValue
            }}
        >
            {children}
        </MenuContext.Provider>
    );
};
