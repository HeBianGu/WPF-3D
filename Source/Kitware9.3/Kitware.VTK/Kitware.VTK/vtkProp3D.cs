using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkProp3D
	/// </summary>
	/// <remarks>
	///    represents an 3D object for placement in a rendered scene
	///
	/// vtkProp3D is an abstract class used to represent an entity in a rendering
	/// scene (i.e., vtkProp3D is a vtkProp with an associated transformation
	/// matrix).  It handles functions related to the position, orientation and
	/// scaling. It combines these instance variables into one 4x4 transformation
	/// matrix as follows: [x y z 1] = [x y z 1] Translate(-origin) Scale(scale)
	/// Rot(y) Rot(x) Rot (z) Trans(origin) Trans(position). Both vtkActor and
	/// vtkVolume are specializations of class vtkProp.  The constructor defaults
	/// to: origin(0,0,0) position=(0,0,0) orientation=(0,0,0), no user defined
	/// matrix or transform, and no texture map.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkProp vtkActor vtkAssembly vtkVolume
	/// </seealso>
	// Token: 0x020000B5 RID: 181
	public abstract class vtkProp3D : vtkProp
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060027AF RID: 10159 RVA: 0x0003A9FB File Offset: 0x00038BFB
		static vtkProp3D()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkProp3D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkProp3D"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060027B0 RID: 10160 RVA: 0x0003AA23 File Offset: 0x00038C23
		public vtkProp3D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060027B1 RID: 10161 RVA: 0x0003AA31 File Offset: 0x00038C31
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060027B2 RID: 10162
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProp3D_AddOrientation_01(HandleRef pThis, double x, double y, double z);

		/// <summary>
		/// Add to the current orientation. See SetOrientation and
		/// GetOrientation for more details. This basically does a
		/// GetOrientation, adds the passed in arguments, and then calls
		/// SetOrientation.
		/// </summary>
		// Token: 0x060027B3 RID: 10163 RVA: 0x0003AA3C File Offset: 0x00038C3C
		public void AddOrientation(double x, double y, double z)
		{
			vtkProp3D.vtkProp3D_AddOrientation_01(base.GetCppThis(), x, y, z);
		}

		// Token: 0x060027B4 RID: 10164
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProp3D_AddOrientation_02(HandleRef pThis, IntPtr orentation);

		/// <summary>
		/// Add to the current orientation. See SetOrientation and
		/// GetOrientation for more details. This basically does a
		/// GetOrientation, adds the passed in arguments, and then calls
		/// SetOrientation.
		/// </summary>
		// Token: 0x060027B5 RID: 10165 RVA: 0x0003AA4E File Offset: 0x00038C4E
		public void AddOrientation(IntPtr orentation)
		{
			vtkProp3D.vtkProp3D_AddOrientation_02(base.GetCppThis(), orentation);
		}

		// Token: 0x060027B6 RID: 10166
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProp3D_AddPosition_03(HandleRef pThis, IntPtr deltaPosition);

		/// <summary>
		/// Set/Get/Add the position of the Prop3D in world coordinates.
		/// </summary>
		// Token: 0x060027B7 RID: 10167 RVA: 0x0003AA5E File Offset: 0x00038C5E
		public void AddPosition(IntPtr deltaPosition)
		{
			vtkProp3D.vtkProp3D_AddPosition_03(base.GetCppThis(), deltaPosition);
		}

		// Token: 0x060027B8 RID: 10168
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProp3D_AddPosition_04(HandleRef pThis, double deltaX, double deltaY, double deltaZ);

		/// <summary>
		/// Set/Get/Add the position of the Prop3D in world coordinates.
		/// </summary>
		// Token: 0x060027B9 RID: 10169 RVA: 0x0003AA6E File Offset: 0x00038C6E
		public void AddPosition(double deltaX, double deltaY, double deltaZ)
		{
			vtkProp3D.vtkProp3D_AddPosition_04(base.GetCppThis(), deltaX, deltaY, deltaZ);
		}

		// Token: 0x060027BA RID: 10170
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProp3D_ComputeMatrix_05(HandleRef pThis);

		/// <summary>
		/// Generate the matrix based on ivars
		/// </summary>
		// Token: 0x060027BB RID: 10171 RVA: 0x0003AA80 File Offset: 0x00038C80
		public virtual void ComputeMatrix()
		{
			vtkProp3D.vtkProp3D_ComputeMatrix_05(base.GetCppThis());
		}

		// Token: 0x060027BC RID: 10172
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProp3D_GetBounds_06(HandleRef pThis, IntPtr bounds);

		/// <summary>
		/// Get the bounds for this Prop3D as (Xmin,Xmax,Ymin,Ymax,Zmin,Zmax).
		/// </summary>
		// Token: 0x060027BD RID: 10173 RVA: 0x0003AA8F File Offset: 0x00038C8F
		public void GetBounds(IntPtr bounds)
		{
			vtkProp3D.vtkProp3D_GetBounds_06(base.GetCppThis(), bounds);
		}

		// Token: 0x060027BE RID: 10174
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProp3D_GetBounds_07(HandleRef pThis);

		/// <summary>
		/// Get the bounds for this Prop3D as (Xmin,Xmax,Ymin,Ymax,Zmin,Zmax).
		/// </summary>
		// Token: 0x060027BF RID: 10175 RVA: 0x0003AAA0 File Offset: 0x00038CA0
		public override double[] GetBounds()
		{
			IntPtr intPtr = vtkProp3D.vtkProp3D_GetBounds_07(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060027C0 RID: 10176
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProp3D_GetCenter_08(HandleRef pThis);

		/// <summary>
		/// Get the center of the bounding box in world coordinates.
		/// </summary>
		// Token: 0x060027C1 RID: 10177 RVA: 0x0003AAE8 File Offset: 0x00038CE8
		public double[] GetCenter()
		{
			IntPtr intPtr = vtkProp3D.vtkProp3D_GetCenter_08(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060027C2 RID: 10178
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkProp3D.CoordinateSystems vtkProp3D_GetCoordinateSystem_09(HandleRef pThis);

		/// <summary>
		/// Specify the coordinate system that this prop is relative to.
		/// This defaults to WORLD but can be set to PHYSICAL which for
		/// VirtualReality is the physical space (aka room) the viewer
		/// is in (in meters). When set to device the CoordinateSystemDevice
		/// is used to place the prop relative to that device (such as a HMD
		/// or controller)
		/// </summary>
		// Token: 0x060027C3 RID: 10179 RVA: 0x0003AB30 File Offset: 0x00038D30
		public virtual vtkProp3D.CoordinateSystems GetCoordinateSystem()
		{
			return vtkProp3D.vtkProp3D_GetCoordinateSystem_09(base.GetCppThis());
		}

		// Token: 0x060027C4 RID: 10180
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProp3D_GetCoordinateSystemAsString_10(HandleRef pThis);

		/// <summary>
		/// Specify the coordinate system that this prop is relative to.
		/// This defaults to WORLD but can be set to PHYSICAL which for
		/// VirtualReality is the physical space (aka room) the viewer
		/// is in (in meters). When set to device the CoordinateSystemDevice
		/// is used to place the prop relative to that device (such as a HMD
		/// or controller)
		/// </summary>
		// Token: 0x060027C5 RID: 10181 RVA: 0x0003AB50 File Offset: 0x00038D50
		public string GetCoordinateSystemAsString()
		{
			string s = Marshal.PtrToStringAnsi(vtkProp3D.vtkProp3D_GetCoordinateSystemAsString_10(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060027C6 RID: 10182
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProp3D_GetCoordinateSystemDevice_11(HandleRef pThis);

		/// <summary>
		/// Specify the device to be used when the coordinate system is set
		/// to DEVICE. Defaults to vtkEventDataDevice::HeadMountedDisplay.
		/// </summary>
		// Token: 0x060027C7 RID: 10183 RVA: 0x0003AB8C File Offset: 0x00038D8C
		public virtual int GetCoordinateSystemDevice()
		{
			return vtkProp3D.vtkProp3D_GetCoordinateSystemDevice_11(base.GetCppThis());
		}

		// Token: 0x060027C8 RID: 10184
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProp3D_GetCoordinateSystemRenderer_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify the Renderer that the prop3d is relative to when the
		/// coordinate system is set to PHYSICAL or DEVICE
		/// </summary>
		// Token: 0x060027C9 RID: 10185 RVA: 0x0003ABAC File Offset: 0x00038DAC
		public vtkRenderer GetCoordinateSystemRenderer()
		{
			vtkRenderer vtkRenderer = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProp3D.vtkProp3D_GetCoordinateSystemRenderer_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRenderer = (vtkRenderer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRenderer.Register(null);
				}
			}
			return vtkRenderer;
		}

		// Token: 0x060027CA RID: 10186
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProp3D_GetIsIdentity_13(HandleRef pThis);

		/// <summary>
		/// Is the matrix for this actor identity
		/// </summary>
		// Token: 0x060027CB RID: 10187 RVA: 0x0003AC1C File Offset: 0x00038E1C
		public virtual int GetIsIdentity()
		{
			return vtkProp3D.vtkProp3D_GetIsIdentity_13(base.GetCppThis());
		}

		// Token: 0x060027CC RID: 10188
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkProp3D_GetLength_14(HandleRef pThis);

		/// <summary>
		/// Get the length of the diagonal of the bounding box.
		/// </summary>
		// Token: 0x060027CD RID: 10189 RVA: 0x0003AC3C File Offset: 0x00038E3C
		public double GetLength()
		{
			return vtkProp3D.vtkProp3D_GetLength_14(base.GetCppThis());
		}

		// Token: 0x060027CE RID: 10190
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkProp3D_GetMTime_15(HandleRef pThis);

		/// <summary>
		/// Get the vtkProp3D's mtime
		/// </summary>
		// Token: 0x060027CF RID: 10191 RVA: 0x0003AC5C File Offset: 0x00038E5C
		public override ulong GetMTime()
		{
			return vtkProp3D.vtkProp3D_GetMTime_15(base.GetCppThis());
		}

		// Token: 0x060027D0 RID: 10192
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProp3D_GetMatrix_16(HandleRef pThis, HandleRef result);

		/// <summary>
		/// Return a reference to the Prop3D's 4x4 composite matrix.
		/// Get the matrix from the position, origin, scale and orientation This
		/// matrix is cached, so multiple GetMatrix() calls will be efficient.
		/// </summary>
		// Token: 0x060027D1 RID: 10193 RVA: 0x0003AC7C File Offset: 0x00038E7C
		public virtual void GetMatrix(vtkMatrix4x4 result)
		{
			vtkProp3D.vtkProp3D_GetMatrix_16(base.GetCppThis(), (result == null) ? default(HandleRef) : result.GetCppThis());
		}

		// Token: 0x060027D2 RID: 10194
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProp3D_GetMatrix_17(HandleRef pThis, IntPtr result);

		/// <summary>
		/// Return a reference to the Prop3D's 4x4 composite matrix.
		/// Get the matrix from the position, origin, scale and orientation This
		/// matrix is cached, so multiple GetMatrix() calls will be efficient.
		/// </summary>
		// Token: 0x060027D3 RID: 10195 RVA: 0x0003ACAB File Offset: 0x00038EAB
		public virtual void GetMatrix(IntPtr result)
		{
			vtkProp3D.vtkProp3D_GetMatrix_17(base.GetCppThis(), result);
		}

		// Token: 0x060027D4 RID: 10196
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProp3D_GetMatrix_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get a pointer to an internal vtkMatrix4x4. that represents
		/// </summary>
		// Token: 0x060027D5 RID: 10197 RVA: 0x0003ACBC File Offset: 0x00038EBC
		public override vtkMatrix4x4 GetMatrix()
		{
			vtkMatrix4x4 vtkMatrix4x = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProp3D.vtkProp3D_GetMatrix_18(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMatrix4x = (vtkMatrix4x4)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMatrix4x.Register(null);
				}
			}
			return vtkMatrix4x;
		}

		// Token: 0x060027D6 RID: 10198
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProp3D_GetModelToWorldMatrix_19(HandleRef pThis, HandleRef result);

		/// <summary>
		/// Return a reference to the Prop3D's Model to World matrix.
		/// This method takes into account the coordinate system the prop is in.
		/// </summary>
		// Token: 0x060027D7 RID: 10199 RVA: 0x0003AD2C File Offset: 0x00038F2C
		public virtual void GetModelToWorldMatrix(vtkMatrix4x4 result)
		{
			vtkProp3D.vtkProp3D_GetModelToWorldMatrix_19(base.GetCppThis(), (result == null) ? default(HandleRef) : result.GetCppThis());
		}

		// Token: 0x060027D8 RID: 10200
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkProp3D_GetNumberOfGenerationsFromBase_20(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060027D9 RID: 10201 RVA: 0x0003AD5C File Offset: 0x00038F5C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkProp3D.vtkProp3D_GetNumberOfGenerationsFromBase_20(base.GetCppThis(), type);
		}

		// Token: 0x060027DA RID: 10202
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkProp3D_GetNumberOfGenerationsFromBaseType_21([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060027DB RID: 10203 RVA: 0x0003AD7C File Offset: 0x00038F7C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkProp3D.vtkProp3D_GetNumberOfGenerationsFromBaseType_21(type);
		}

		// Token: 0x060027DC RID: 10204
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProp3D_GetOrientation_22(HandleRef pThis);

		/// <summary>
		/// Returns the orientation of the Prop3D as s vector of X,Y and Z rotation.
		/// The ordering in which these rotations must be done to generate the
		/// same matrix is RotateZ, RotateX, and finally RotateY. See also
		/// SetOrientation.
		/// </summary>
		// Token: 0x060027DD RID: 10205 RVA: 0x0003AD98 File Offset: 0x00038F98
		public double[] GetOrientation()
		{
			IntPtr intPtr = vtkProp3D.vtkProp3D_GetOrientation_22(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060027DE RID: 10206
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProp3D_GetOrientation_23(HandleRef pThis, IntPtr orentation);

		/// <summary>
		/// Returns the orientation of the Prop3D as s vector of X,Y and Z rotation.
		/// The ordering in which these rotations must be done to generate the
		/// same matrix is RotateZ, RotateX, and finally RotateY. See also
		/// SetOrientation.
		/// </summary>
		// Token: 0x060027DF RID: 10207 RVA: 0x0003ADE0 File Offset: 0x00038FE0
		public void GetOrientation(IntPtr orentation)
		{
			vtkProp3D.vtkProp3D_GetOrientation_23(base.GetCppThis(), orentation);
		}

		// Token: 0x060027E0 RID: 10208
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProp3D_GetOrientationWXYZ_24(HandleRef pThis);

		/// <summary>
		/// Returns the WXYZ orientation of the Prop3D.
		/// </summary>
		// Token: 0x060027E1 RID: 10209 RVA: 0x0003ADF0 File Offset: 0x00038FF0
		public double[] GetOrientationWXYZ()
		{
			IntPtr intPtr = vtkProp3D.vtkProp3D_GetOrientationWXYZ_24(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[4];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060027E2 RID: 10210
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProp3D_GetOrigin_25(HandleRef pThis);

		/// <summary>
		/// Set/Get the origin of the Prop3D. This is the point about which all
		/// rotations take place.
		/// </summary>
		// Token: 0x060027E3 RID: 10211 RVA: 0x0003AE38 File Offset: 0x00039038
		public virtual double[] GetOrigin()
		{
			IntPtr intPtr = vtkProp3D.vtkProp3D_GetOrigin_25(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060027E4 RID: 10212
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProp3D_GetOrigin_26(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set/Get the origin of the Prop3D. This is the point about which all
		/// rotations take place.
		/// </summary>
		// Token: 0x060027E5 RID: 10213 RVA: 0x0003AE80 File Offset: 0x00039080
		public virtual void GetOrigin(IntPtr data)
		{
			vtkProp3D.vtkProp3D_GetOrigin_26(base.GetCppThis(), data);
		}

		// Token: 0x060027E6 RID: 10214
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProp3D_GetPosition_27(HandleRef pThis);

		/// <summary>
		/// Set/Get/Add the position of the Prop3D in world coordinates.
		/// </summary>
		// Token: 0x060027E7 RID: 10215 RVA: 0x0003AE90 File Offset: 0x00039090
		public virtual double[] GetPosition()
		{
			IntPtr intPtr = vtkProp3D.vtkProp3D_GetPosition_27(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060027E8 RID: 10216
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProp3D_GetPosition_28(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set/Get/Add the position of the Prop3D in world coordinates.
		/// </summary>
		// Token: 0x060027E9 RID: 10217 RVA: 0x0003AED8 File Offset: 0x000390D8
		public virtual void GetPosition(IntPtr data)
		{
			vtkProp3D.vtkProp3D_GetPosition_28(base.GetCppThis(), data);
		}

		// Token: 0x060027EA RID: 10218
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProp3D_GetScale_29(HandleRef pThis);

		/// <summary>
		/// Set/Get the scale of the actor. Scaling in performed independently on the
		/// X, Y and Z axis. A scale of zero is illegal and will be replaced with one.
		/// </summary>
		// Token: 0x060027EB RID: 10219 RVA: 0x0003AEE8 File Offset: 0x000390E8
		public virtual double[] GetScale()
		{
			IntPtr intPtr = vtkProp3D.vtkProp3D_GetScale_29(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060027EC RID: 10220
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProp3D_GetScale_30(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set/Get the scale of the actor. Scaling in performed independently on the
		/// X, Y and Z axis. A scale of zero is illegal and will be replaced with one.
		/// </summary>
		// Token: 0x060027ED RID: 10221 RVA: 0x0003AF30 File Offset: 0x00039130
		public virtual void GetScale(IntPtr data)
		{
			vtkProp3D.vtkProp3D_GetScale_30(base.GetCppThis(), data);
		}

		// Token: 0x060027EE RID: 10222
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProp3D_GetUserMatrix_31(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// The UserMatrix can be used in place of UserTransform.
		/// </summary>
		// Token: 0x060027EF RID: 10223 RVA: 0x0003AF40 File Offset: 0x00039140
		public vtkMatrix4x4 GetUserMatrix()
		{
			vtkMatrix4x4 vtkMatrix4x = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProp3D.vtkProp3D_GetUserMatrix_31(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMatrix4x = (vtkMatrix4x4)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMatrix4x.Register(null);
				}
			}
			return vtkMatrix4x;
		}

		// Token: 0x060027F0 RID: 10224
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProp3D_GetUserTransform_32(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// In addition to the instance variables such as position and orientation,
		/// you can add an additional transformation for your own use.  This
		/// transformation is concatenated with the actor's internal transformation,
		/// which you implicitly create through the use of SetPosition(),
		/// SetOrigin() and SetOrientation().
		/// &lt;p&gt;If the internal transformation
		/// is identity (i.e. if you don't set the Position, Origin, or
		/// Orientation) then the actors final transformation will be the
		/// UserTransform, concatenated with the UserMatrix if the UserMatrix
		/// is present.
		/// </summary>
		// Token: 0x060027F1 RID: 10225 RVA: 0x0003AFB0 File Offset: 0x000391B0
		public virtual vtkLinearTransform GetUserTransform()
		{
			vtkLinearTransform vtkLinearTransform = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProp3D.vtkProp3D_GetUserTransform_32(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLinearTransform = (vtkLinearTransform)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLinearTransform.Register(null);
				}
			}
			return vtkLinearTransform;
		}

		// Token: 0x060027F2 RID: 10226
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkProp3D_GetUserTransformMatrixMTime_33(HandleRef pThis);

		/// <summary>
		/// Get the modified time of the user matrix or user transform.
		/// </summary>
		// Token: 0x060027F3 RID: 10227 RVA: 0x0003B020 File Offset: 0x00039220
		public ulong GetUserTransformMatrixMTime()
		{
			return vtkProp3D.vtkProp3D_GetUserTransformMatrixMTime_33(base.GetCppThis());
		}

		// Token: 0x060027F4 RID: 10228
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProp3D_GetXRange_34(HandleRef pThis);

		/// <summary>
		/// Get the Prop3D's x range in world coordinates.
		/// </summary>
		// Token: 0x060027F5 RID: 10229 RVA: 0x0003B040 File Offset: 0x00039240
		public double[] GetXRange()
		{
			IntPtr intPtr = vtkProp3D.vtkProp3D_GetXRange_34(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060027F6 RID: 10230
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProp3D_GetYRange_35(HandleRef pThis);

		/// <summary>
		/// Get the Prop3D's y range in world coordinates.
		/// </summary>
		// Token: 0x060027F7 RID: 10231 RVA: 0x0003B088 File Offset: 0x00039288
		public double[] GetYRange()
		{
			IntPtr intPtr = vtkProp3D.vtkProp3D_GetYRange_35(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060027F8 RID: 10232
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProp3D_GetZRange_36(HandleRef pThis);

		/// <summary>
		/// Get the Prop3D's z range in world coordinates.
		/// </summary>
		// Token: 0x060027F9 RID: 10233 RVA: 0x0003B0D0 File Offset: 0x000392D0
		public double[] GetZRange()
		{
			IntPtr intPtr = vtkProp3D.vtkProp3D_GetZRange_36(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060027FA RID: 10234
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProp3D_InitPathTraversal_37(HandleRef pThis);

		/// <summary>
		/// Overload vtkProp's method for setting up assembly paths. See
		/// the documentation for vtkProp.
		/// </summary>
		// Token: 0x060027FB RID: 10235 RVA: 0x0003B118 File Offset: 0x00039318
		public override void InitPathTraversal()
		{
			vtkProp3D.vtkProp3D_InitPathTraversal_37(base.GetCppThis());
		}

		// Token: 0x060027FC RID: 10236
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProp3D_IsA_38(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060027FD RID: 10237 RVA: 0x0003B128 File Offset: 0x00039328
		public override int IsA(string type)
		{
			return vtkProp3D.vtkProp3D_IsA_38(base.GetCppThis(), type);
		}

		// Token: 0x060027FE RID: 10238
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProp3D_IsTypeOf_39([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060027FF RID: 10239 RVA: 0x0003B148 File Offset: 0x00039348
		public new static int IsTypeOf(string type)
		{
			return vtkProp3D.vtkProp3D_IsTypeOf_39(type);
		}

		// Token: 0x06002800 RID: 10240
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProp3D_NewInstance_40(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002801 RID: 10241 RVA: 0x0003B164 File Offset: 0x00039364
		public new vtkProp3D NewInstance()
		{
			vtkProp3D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProp3D.vtkProp3D_NewInstance_40(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkProp3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06002802 RID: 10242
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProp3D_PokeMatrix_41(HandleRef pThis, HandleRef matrix);

		/// <summary>
		/// This method modifies the vtkProp3D so that its transformation
		/// state is set to the matrix specified. The method does this by
		/// setting appropriate transformation-related ivars to initial
		/// values (i.e., not transformed), and placing the user-supplied
		/// matrix into the UserMatrix of this vtkProp3D. If the method is
		/// called again with a NULL matrix, then the original state of the
		/// vtkProp3D will be restored. This method is used to support
		/// picking and assembly structures.
		/// </summary>
		// Token: 0x06002803 RID: 10243 RVA: 0x0003B1C0 File Offset: 0x000393C0
		public override void PokeMatrix(vtkMatrix4x4 matrix)
		{
			vtkProp3D.vtkProp3D_PokeMatrix_41(base.GetCppThis(), (matrix == null) ? default(HandleRef) : matrix.GetCppThis());
		}

		// Token: 0x06002804 RID: 10244
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProp3D_RotateWXYZ_42(HandleRef pThis, double w, double x, double y, double z);

		/// <summary>
		/// Rotate the Prop3D in degrees about an arbitrary axis specified by
		/// the last three arguments. The axis is specified in world
		/// coordinates. To rotate an about its model axes, use RotateX,
		/// RotateY, RotateZ.
		/// </summary>
		// Token: 0x06002805 RID: 10245 RVA: 0x0003B1EF File Offset: 0x000393EF
		public void RotateWXYZ(double w, double x, double y, double z)
		{
			vtkProp3D.vtkProp3D_RotateWXYZ_42(base.GetCppThis(), w, x, y, z);
		}

		// Token: 0x06002806 RID: 10246
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProp3D_RotateX_43(HandleRef pThis, double arg0);

		/// <summary>
		/// Rotate the Prop3D in degrees about the X axis using the right hand
		/// rule. The axis is the Prop3D's X axis, which can change as other
		/// rotations are performed.  To rotate about the world X axis use
		/// RotateWXYZ (angle, 1, 0, 0). This rotation is applied before all
		/// others in the current transformation matrix.
		/// </summary>
		// Token: 0x06002807 RID: 10247 RVA: 0x0003B203 File Offset: 0x00039403
		public void RotateX(double arg0)
		{
			vtkProp3D.vtkProp3D_RotateX_43(base.GetCppThis(), arg0);
		}

		// Token: 0x06002808 RID: 10248
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProp3D_RotateY_44(HandleRef pThis, double arg0);

		/// <summary>
		/// Rotate the Prop3D in degrees about the Y axis using the right hand
		/// rule. The axis is the Prop3D's Y axis, which can change as other
		/// rotations are performed.  To rotate about the world Y axis use
		/// RotateWXYZ (angle, 0, 1, 0). This rotation is applied before all
		/// others in the current transformation matrix.
		/// </summary>
		// Token: 0x06002809 RID: 10249 RVA: 0x0003B213 File Offset: 0x00039413
		public void RotateY(double arg0)
		{
			vtkProp3D.vtkProp3D_RotateY_44(base.GetCppThis(), arg0);
		}

		// Token: 0x0600280A RID: 10250
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProp3D_RotateZ_45(HandleRef pThis, double arg0);

		/// <summary>
		/// Rotate the Prop3D in degrees about the Z axis using the right hand
		/// rule. The axis is the Prop3D's Z axis, which can change as other
		/// rotations are performed.  To rotate about the world Z axis use
		/// RotateWXYZ (angle, 0, 0, 1). This rotation is applied before all
		/// others in the current transformation matrix.
		/// </summary>
		// Token: 0x0600280B RID: 10251 RVA: 0x0003B223 File Offset: 0x00039423
		public void RotateZ(double arg0)
		{
			vtkProp3D.vtkProp3D_RotateZ_45(base.GetCppThis(), arg0);
		}

		// Token: 0x0600280C RID: 10252
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProp3D_SafeDownCast_46(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600280D RID: 10253 RVA: 0x0003B234 File Offset: 0x00039434
		public new static vtkProp3D SafeDownCast(vtkObjectBase o)
		{
			vtkProp3D vtkProp3D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProp3D.vtkProp3D_SafeDownCast_46((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProp3D = (vtkProp3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProp3D.Register(null);
				}
			}
			return vtkProp3D;
		}

		// Token: 0x0600280E RID: 10254
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProp3D_SetCoordinateSystem_47(HandleRef pThis, vtkProp3D.CoordinateSystems val);

		/// <summary>
		/// Specify the coordinate system that this prop is relative to.
		/// This defaults to WORLD but can be set to PHYSICAL which for
		/// VirtualReality is the physical space (aka room) the viewer
		/// is in (in meters). When set to device the CoordinateSystemDevice
		/// is used to place the prop relative to that device (such as a HMD
		/// or controller)
		/// </summary>
		// Token: 0x0600280F RID: 10255 RVA: 0x0003B2B3 File Offset: 0x000394B3
		public void SetCoordinateSystem(vtkProp3D.CoordinateSystems val)
		{
			vtkProp3D.vtkProp3D_SetCoordinateSystem_47(base.GetCppThis(), val);
		}

		// Token: 0x06002810 RID: 10256
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProp3D_SetCoordinateSystemDevice_48(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify the device to be used when the coordinate system is set
		/// to DEVICE. Defaults to vtkEventDataDevice::HeadMountedDisplay.
		/// </summary>
		// Token: 0x06002811 RID: 10257 RVA: 0x0003B2C3 File Offset: 0x000394C3
		public virtual void SetCoordinateSystemDevice(int _arg)
		{
			vtkProp3D.vtkProp3D_SetCoordinateSystemDevice_48(base.GetCppThis(), _arg);
		}

		// Token: 0x06002812 RID: 10258
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProp3D_SetCoordinateSystemRenderer_49(HandleRef pThis, HandleRef ren);

		/// <summary>
		/// Specify the Renderer that the prop3d is relative to when the
		/// coordinate system is set to PHYSICAL or DEVICE
		/// </summary>
		// Token: 0x06002813 RID: 10259 RVA: 0x0003B2D4 File Offset: 0x000394D4
		public void SetCoordinateSystemRenderer(vtkRenderer ren)
		{
			vtkProp3D.vtkProp3D_SetCoordinateSystemRenderer_49(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis());
		}

		// Token: 0x06002814 RID: 10260
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProp3D_SetCoordinateSystemToDevice_50(HandleRef pThis);

		/// <summary>
		/// Specify the coordinate system that this prop is relative to.
		/// This defaults to WORLD but can be set to PHYSICAL which for
		/// VirtualReality is the physical space (aka room) the viewer
		/// is in (in meters). When set to device the CoordinateSystemDevice
		/// is used to place the prop relative to that device (such as a HMD
		/// or controller)
		/// </summary>
		// Token: 0x06002815 RID: 10261 RVA: 0x0003B303 File Offset: 0x00039503
		public void SetCoordinateSystemToDevice()
		{
			vtkProp3D.vtkProp3D_SetCoordinateSystemToDevice_50(base.GetCppThis());
		}

		// Token: 0x06002816 RID: 10262
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProp3D_SetCoordinateSystemToPhysical_51(HandleRef pThis);

		/// <summary>
		/// Specify the coordinate system that this prop is relative to.
		/// This defaults to WORLD but can be set to PHYSICAL which for
		/// VirtualReality is the physical space (aka room) the viewer
		/// is in (in meters). When set to device the CoordinateSystemDevice
		/// is used to place the prop relative to that device (such as a HMD
		/// or controller)
		/// </summary>
		// Token: 0x06002817 RID: 10263 RVA: 0x0003B312 File Offset: 0x00039512
		public void SetCoordinateSystemToPhysical()
		{
			vtkProp3D.vtkProp3D_SetCoordinateSystemToPhysical_51(base.GetCppThis());
		}

		// Token: 0x06002818 RID: 10264
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProp3D_SetCoordinateSystemToWorld_52(HandleRef pThis);

		/// <summary>
		/// Specify the coordinate system that this prop is relative to.
		/// This defaults to WORLD but can be set to PHYSICAL which for
		/// VirtualReality is the physical space (aka room) the viewer
		/// is in (in meters). When set to device the CoordinateSystemDevice
		/// is used to place the prop relative to that device (such as a HMD
		/// or controller)
		/// </summary>
		// Token: 0x06002819 RID: 10265 RVA: 0x0003B321 File Offset: 0x00039521
		public void SetCoordinateSystemToWorld()
		{
			vtkProp3D.vtkProp3D_SetCoordinateSystemToWorld_52(base.GetCppThis());
		}

		// Token: 0x0600281A RID: 10266
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProp3D_SetOrientation_53(HandleRef pThis, double x, double y, double z);

		/// <summary>
		/// Sets the orientation of the Prop3D.  Orientation is specified as
		/// X,Y and Z rotations in that order, but they are performed as
		/// RotateZ, RotateX, and finally RotateY.
		/// </summary>
		// Token: 0x0600281B RID: 10267 RVA: 0x0003B330 File Offset: 0x00039530
		public void SetOrientation(double x, double y, double z)
		{
			vtkProp3D.vtkProp3D_SetOrientation_53(base.GetCppThis(), x, y, z);
		}

		// Token: 0x0600281C RID: 10268
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProp3D_SetOrientation_54(HandleRef pThis, IntPtr orientation);

		/// <summary>
		/// Sets the orientation of the Prop3D.  Orientation is specified as
		/// X,Y and Z rotations in that order, but they are performed as
		/// RotateZ, RotateX, and finally RotateY.
		/// </summary>
		// Token: 0x0600281D RID: 10269 RVA: 0x0003B342 File Offset: 0x00039542
		public void SetOrientation(IntPtr orientation)
		{
			vtkProp3D.vtkProp3D_SetOrientation_54(base.GetCppThis(), orientation);
		}

		// Token: 0x0600281E RID: 10270
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProp3D_SetOrigin_55(HandleRef pThis, double x, double y, double z);

		/// <summary>
		/// Set/Get the origin of the Prop3D. This is the point about which all
		/// rotations take place.
		/// </summary>
		// Token: 0x0600281F RID: 10271 RVA: 0x0003B352 File Offset: 0x00039552
		public virtual void SetOrigin(double x, double y, double z)
		{
			vtkProp3D.vtkProp3D_SetOrigin_55(base.GetCppThis(), x, y, z);
		}

		// Token: 0x06002820 RID: 10272
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProp3D_SetOrigin_56(HandleRef pThis, IntPtr pos);

		/// <summary>
		/// Set/Get the origin of the Prop3D. This is the point about which all
		/// rotations take place.
		/// </summary>
		// Token: 0x06002821 RID: 10273 RVA: 0x0003B364 File Offset: 0x00039564
		public virtual void SetOrigin(IntPtr pos)
		{
			vtkProp3D.vtkProp3D_SetOrigin_56(base.GetCppThis(), pos);
		}

		// Token: 0x06002822 RID: 10274
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProp3D_SetPosition_57(HandleRef pThis, double x, double y, double z);

		/// <summary>
		/// Set/Get/Add the position of the Prop3D in world coordinates.
		/// </summary>
		// Token: 0x06002823 RID: 10275 RVA: 0x0003B374 File Offset: 0x00039574
		public virtual void SetPosition(double x, double y, double z)
		{
			vtkProp3D.vtkProp3D_SetPosition_57(base.GetCppThis(), x, y, z);
		}

		// Token: 0x06002824 RID: 10276
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProp3D_SetPosition_58(HandleRef pThis, IntPtr pos);

		/// <summary>
		/// Set/Get/Add the position of the Prop3D in world coordinates.
		/// </summary>
		// Token: 0x06002825 RID: 10277 RVA: 0x0003B386 File Offset: 0x00039586
		public virtual void SetPosition(IntPtr pos)
		{
			vtkProp3D.vtkProp3D_SetPosition_58(base.GetCppThis(), pos);
		}

		// Token: 0x06002826 RID: 10278
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProp3D_SetPropertiesFromModelToWorldMatrix_59(HandleRef pThis, HandleRef modelToWorld);

		/// <summary>
		/// Set the position, scale, orientation from a provided model to world matrix.
		/// If the prop is in a coordinate system other than world, then ren must be non-null
		/// </summary>
		// Token: 0x06002827 RID: 10279 RVA: 0x0003B398 File Offset: 0x00039598
		public virtual void SetPropertiesFromModelToWorldMatrix(vtkMatrix4x4 modelToWorld)
		{
			vtkProp3D.vtkProp3D_SetPropertiesFromModelToWorldMatrix_59(base.GetCppThis(), (modelToWorld == null) ? default(HandleRef) : modelToWorld.GetCppThis());
		}

		// Token: 0x06002828 RID: 10280
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProp3D_SetScale_60(HandleRef pThis, double x, double y, double z);

		/// <summary>
		/// Set/Get the scale of the actor. Scaling in performed independently on the
		/// X, Y and Z axis. A scale of zero is illegal and will be replaced with one.
		/// </summary>
		// Token: 0x06002829 RID: 10281 RVA: 0x0003B3C7 File Offset: 0x000395C7
		public virtual void SetScale(double x, double y, double z)
		{
			vtkProp3D.vtkProp3D_SetScale_60(base.GetCppThis(), x, y, z);
		}

		// Token: 0x0600282A RID: 10282
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProp3D_SetScale_61(HandleRef pThis, IntPtr scale);

		/// <summary>
		/// Set/Get the scale of the actor. Scaling in performed independently on the
		/// X, Y and Z axis. A scale of zero is illegal and will be replaced with one.
		/// </summary>
		// Token: 0x0600282B RID: 10283 RVA: 0x0003B3D9 File Offset: 0x000395D9
		public virtual void SetScale(IntPtr scale)
		{
			vtkProp3D.vtkProp3D_SetScale_61(base.GetCppThis(), scale);
		}

		// Token: 0x0600282C RID: 10284
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProp3D_SetScale_62(HandleRef pThis, double s);

		/// <summary>
		/// Method to set the scale isotropically
		/// </summary>
		// Token: 0x0600282D RID: 10285 RVA: 0x0003B3E9 File Offset: 0x000395E9
		public void SetScale(double s)
		{
			vtkProp3D.vtkProp3D_SetScale_62(base.GetCppThis(), s);
		}

		// Token: 0x0600282E RID: 10286
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProp3D_SetUserMatrix_63(HandleRef pThis, HandleRef matrix);

		/// <summary>
		/// The UserMatrix can be used in place of UserTransform.
		/// </summary>
		// Token: 0x0600282F RID: 10287 RVA: 0x0003B3FC File Offset: 0x000395FC
		public void SetUserMatrix(vtkMatrix4x4 matrix)
		{
			vtkProp3D.vtkProp3D_SetUserMatrix_63(base.GetCppThis(), (matrix == null) ? default(HandleRef) : matrix.GetCppThis());
		}

		// Token: 0x06002830 RID: 10288
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProp3D_SetUserTransform_64(HandleRef pThis, HandleRef transform);

		/// <summary>
		/// In addition to the instance variables such as position and orientation,
		/// you can add an additional transformation for your own use.  This
		/// transformation is concatenated with the actor's internal transformation,
		/// which you implicitly create through the use of SetPosition(),
		/// SetOrigin() and SetOrientation().
		/// &lt;p&gt;If the internal transformation
		/// is identity (i.e. if you don't set the Position, Origin, or
		/// Orientation) then the actors final transformation will be the
		/// UserTransform, concatenated with the UserMatrix if the UserMatrix
		/// is present.
		/// </summary>
		// Token: 0x06002831 RID: 10289 RVA: 0x0003B42C File Offset: 0x0003962C
		public void SetUserTransform(vtkLinearTransform transform)
		{
			vtkProp3D.vtkProp3D_SetUserTransform_64(base.GetCppThis(), (transform == null) ? default(HandleRef) : transform.GetCppThis());
		}

		// Token: 0x06002832 RID: 10290
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProp3D_ShallowCopy_65(HandleRef pThis, HandleRef prop);

		/// <summary>
		/// Shallow copy of this vtkProp3D.
		/// </summary>
		// Token: 0x06002833 RID: 10291 RVA: 0x0003B45C File Offset: 0x0003965C
		public override void ShallowCopy(vtkProp prop)
		{
			vtkProp3D.vtkProp3D_ShallowCopy_65(base.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000554 RID: 1364
		public new const string MRFullTypeName = "Kitware.VTK.vtkProp3D";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000555 RID: 1365
		public new static readonly string MRClassNameKey = "class vtkProp3D";

		/// <summary>
		/// Specify the coordinate system that this prop is relative to.
		/// This defaults to WORLD but can be set to PHYSICAL which for
		/// VirtualReality is the physical space (aka room) the viewer
		/// is in (in meters). When set to device the CoordinateSystemDevice
		/// is used to place the prop relative to that device (such as a HMD
		/// or controller)
		/// </summary>
		// Token: 0x020000B6 RID: 182
		public enum CoordinateSystems
		{
			/// <summary>enum member</summary>
			// Token: 0x04000557 RID: 1367
			DEVICE = 2,
			/// <summary>enum member</summary>
			// Token: 0x04000558 RID: 1368
			PHYSICAL = 1,
			/// <summary>enum member</summary>
			// Token: 0x04000559 RID: 1369
			WORLD = 0
		}
	}
}
