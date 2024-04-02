import SearchBar from "./SearchBar";

const Table = () => {
  return (
    <div className="w-full border-2 ">
      <div className="flex justify-between items-center px-3 py-2 pr-10">
        <SearchBar />
        <div>
          <button className="text-3xl">&lt;</button> {"    "}
          <button className="text-3xl">&gt;</button>
        </div>
      </div>
      <hr />
      <table className=" w-full text-left">
        <thead>
          <tr className="bg-nude mb-10">
            <th>Status</th>
            <th>Code</th>
            <th>Percent</th>
            <th>Start</th>
            <th>Expires on</th>
            <th>Action</th>
          </tr>
        </thead>

        <tbody className="text-sm mt-5">
          <tr className="py-3">
            <td>
              <span className="text-[6px]">🟢 &nbsp;</span> Active
            </td>
            <td>
              <span>CHRISMAS_20</span>
            </td>
            <td>20</td>
            <td>30 March 2024</td>
            <td>30 April 2024</td>
            <button>Edit</button>
            <button>Delete</button>
          </tr>
        </tbody>
      </table>
    </div>
  );
};

export default Table;
