import React, { useEffect, useState } from "react";
import TemplateDataMenu from "./TemplateDataMenu";
import Manage from "../Manage";
import axios from "axios";
import "../styles.css";

const ManageMenu = () => {
    const [data, setData] = useState(null);
    useEffect(async () => {
        const fetchData = async () => {
            try {
                const response = await axios.get(
                    "http://localhost:5146/api/Drink/getallgrouped"
                );
                // const data = await response.json();
                setData(response.data);
                // console.log(data);
            } catch (error) {
                console.log("Error: " + error);
            } finally {
                // handle Loading
            }
        };

        await fetchData();
        console.log(data);
    }, []);

    //! Truyền data, type cho component Manage để sài chung
    return <Manage data={TemplateDataMenu} type={"menu"}></Manage>;
};

export default ManageMenu;
