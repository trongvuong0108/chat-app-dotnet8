import { Button } from "antd";
import style from "./login.module.scss";

const login = () => {
  return (
    <div className={`${style.container}`}>
      <h1>Login</h1>
      <form className={`${style.form}`}>
        <label className={`${style.label}`}>Email</label>
        <input className={`${style.input}`} type="text" placeholder="Email" />
        <label className={`${style.label}`}>Password</label>
        <input
          className={`${style.input}`}
          type="password"
          placeholder="Password"
        />
        <Button type="primary" htmlType="submit">
          Login
        </Button>
        <Button type="primary" htmlType="submit">
          Google Login
        </Button>
      </form>
    </div>
  );
};

export default login;
