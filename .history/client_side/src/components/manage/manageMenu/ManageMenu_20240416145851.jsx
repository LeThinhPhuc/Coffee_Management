import React, { useEffect, useState } from "react";
import TemplateDataMenu from "./TemplateDataMenu";
import Manage from "../Manage";

const ManageMenu = () => {
    const [data, setData] = useState(null);
    useEffect(() => {
        const fetchData = async () => {
            try {
                const response = await axios.get(
                    "http://localhost:5146/api/Drink/getallgrouped"
                );
                setData(response.data);
            } catch (error) {
                console.log("Error: " + error);
            }
            //   finally {
            //   }
        };

        fetchData();
    }, []);

    //! Truyền data, type cho component Manage để sài chung
    return <Manage data={TemplateDataMenu} type={"menu"}></Manage>;
};

export default ManageMenu;
