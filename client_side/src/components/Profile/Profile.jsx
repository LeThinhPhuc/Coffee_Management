// Coffee_Management/client_side/src/components/Profile/Profile.jsx

const Profile = () => {
  let user = null;
  let shop = null;

  // Attempt to fetch the user data from localStorage
  try {
    const userData = JSON.parse(localStorage.getItem("user"));
    if (userData && userData.user) {
      user = userData.user;
      shop = userData.shops[0]; // get first shop
    } else {
      console.warn("User data is not available");
    }
  } catch (error) {
    console.warn(
      "User data is not available in localStorage or is malformed",
      error
    );
  }

  if (!user) {
    return (
      <div className="flex items-center justify-center h-screen">
        <p className="text-lg text-gray-600">
          Please log in to view your profile information.
        </p>
      </div>
    );
  }

  return (
    <div>
      <div className="max-w-md mx-auto mt-10 p-6 bg-white shadow-lg rounded-lg">
        <h2 className="text-2xl font-bold mb-4 text-gray-800">Profile</h2>
        <div className="space-y-2">
          <p className="text-gray-700">
            <strong>Username:</strong> {user.userName}
          </p>
          <p className="text-gray-700">
            <strong>Full Name:</strong> {user.fullName}
          </p>
          <p className="text-gray-700">
            <strong>Email:</strong> {user.email || "N/A"}
          </p>
          <p className="text-gray-700">
            <strong>Date Joined:</strong> {user.dateJoined || "N/A"}
          </p>
          <p className="text-gray-700">
            <strong>Roles:</strong> {user.roles.join(", ")}
          </p>
        </div>
      </div>

      {shop && (
        <div className="max-w-md mx-auto mt-10 p-6 bg-white shadow-lg rounded-lg">
          <h2 className="text-2xl font-bold mb-4 text-gray-800">Shops (first shop)</h2>
          <div className="space-y-2">
            <p className="text-gray-700">
              <strong>Your shop name:</strong> {shop.name}
            </p>
            <p className="text-gray-700">
              <strong>Address:</strong> {shop.address}
            </p>
            <p className="text-gray-700 flex items-center">
              <strong>Approval status:</strong>
              {shop.isApproved ? (
                <span className="text-green-500 ml-2">✔</span>
              ) : (
                <span className="text-red-500 ml-2">✘</span>
              )}
            </p>
            <p className="text-gray-700 flex items-center">
              <strong>Suspension status:</strong>
              {shop.isSuspended ? (
                <span className="text-green-500 ml-2">✔</span>
              ) : (
                <span className="text-red-500 ml-2">✘</span>
              )}
            </p>
            <p className="text-gray-700">
              <strong>Date Created:</strong> {shop.dateCreated || "N/A"}
            </p>
          </div>
        </div>
      )}
    </div>
  );
};

export default Profile;
