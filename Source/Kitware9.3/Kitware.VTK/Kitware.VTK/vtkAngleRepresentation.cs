using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkAngleRepresentation
	/// </summary>
	/// <remarks>
	///    represent the vtkAngleWidget
	///
	/// The vtkAngleRepresentation is a superclass for classes representing the
	/// vtkAngleWidget. This representation consists of two rays and three
	/// vtkHandleRepresentations to place and manipulate the three points defining
	/// the angle representation. (Note: the three points are referred to as Point1,
	/// Center, and Point2, at the two end points (Point1 and Point2) and Center
	/// (around which the angle is measured).
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkAngleWidget vtkHandleRepresentation vtkAngleRepresentation2D
	/// </seealso>
	// Token: 0x020002B7 RID: 695
	public abstract class vtkAngleRepresentation : vtkWidgetRepresentation
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06007DB6 RID: 32182 RVA: 0x000B4877 File Offset: 0x000B2A77
		static vtkAngleRepresentation()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAngleRepresentation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAngleRepresentation"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06007DB7 RID: 32183 RVA: 0x000B489F File Offset: 0x000B2A9F
		public vtkAngleRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06007DB8 RID: 32184 RVA: 0x000B48AD File Offset: 0x000B2AAD
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06007DB9 RID: 32185
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAngleRepresentation_ArcVisibilityOff_01(HandleRef pThis);

		/// <summary>
		/// Special methods for turning off the rays and arc that define the cone
		/// and arc of the angle.
		/// </summary>
		// Token: 0x06007DBA RID: 32186 RVA: 0x000B48B8 File Offset: 0x000B2AB8
		public virtual void ArcVisibilityOff()
		{
			vtkAngleRepresentation.vtkAngleRepresentation_ArcVisibilityOff_01(base.GetCppThis());
		}

		// Token: 0x06007DBB RID: 32187
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAngleRepresentation_ArcVisibilityOn_02(HandleRef pThis);

		/// <summary>
		/// Special methods for turning off the rays and arc that define the cone
		/// and arc of the angle.
		/// </summary>
		// Token: 0x06007DBC RID: 32188 RVA: 0x000B48C7 File Offset: 0x000B2AC7
		public virtual void ArcVisibilityOn()
		{
			vtkAngleRepresentation.vtkAngleRepresentation_ArcVisibilityOn_02(base.GetCppThis());
		}

		// Token: 0x06007DBD RID: 32189
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAngleRepresentation_BuildRepresentation_03(HandleRef pThis);

		/// <summary>
		/// These are methods that satisfy vtkWidgetRepresentation's API.
		/// </summary>
		// Token: 0x06007DBE RID: 32190 RVA: 0x000B48D6 File Offset: 0x000B2AD6
		public override void BuildRepresentation()
		{
			vtkAngleRepresentation.vtkAngleRepresentation_BuildRepresentation_03(base.GetCppThis());
		}

		// Token: 0x06007DBF RID: 32191
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAngleRepresentation_CenterWidgetInteraction_04(HandleRef pThis, IntPtr e);

		/// <summary>
		/// These are methods that satisfy vtkWidgetRepresentation's API.
		/// </summary>
		// Token: 0x06007DC0 RID: 32192 RVA: 0x000B48E5 File Offset: 0x000B2AE5
		public virtual void CenterWidgetInteraction(IntPtr e)
		{
			vtkAngleRepresentation.vtkAngleRepresentation_CenterWidgetInteraction_04(base.GetCppThis(), e);
		}

		// Token: 0x06007DC1 RID: 32193
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAngleRepresentation_ComputeInteractionState_05(HandleRef pThis, int X, int Y, int modify);

		/// <summary>
		/// These are methods that satisfy vtkWidgetRepresentation's API.
		/// </summary>
		// Token: 0x06007DC2 RID: 32194 RVA: 0x000B48F8 File Offset: 0x000B2AF8
		public override int ComputeInteractionState(int X, int Y, int modify)
		{
			return vtkAngleRepresentation.vtkAngleRepresentation_ComputeInteractionState_05(base.GetCppThis(), X, Y, modify);
		}

		// Token: 0x06007DC3 RID: 32195
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAngleRepresentation_GetAngle_06(HandleRef pThis);

		/// <summary>
		/// This representation and all subclasses must keep an angle (in degrees)
		/// consistent with the state of the widget.
		/// </summary>
		// Token: 0x06007DC4 RID: 32196 RVA: 0x000B491C File Offset: 0x000B2B1C
		public virtual double GetAngle()
		{
			return vtkAngleRepresentation.vtkAngleRepresentation_GetAngle_06(base.GetCppThis());
		}

		// Token: 0x06007DC5 RID: 32197
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAngleRepresentation_GetArcVisibility_07(HandleRef pThis);

		/// <summary>
		/// Special methods for turning off the rays and arc that define the cone
		/// and arc of the angle.
		/// </summary>
		// Token: 0x06007DC6 RID: 32198 RVA: 0x000B493C File Offset: 0x000B2B3C
		public virtual int GetArcVisibility()
		{
			return vtkAngleRepresentation.vtkAngleRepresentation_GetArcVisibility_07(base.GetCppThis());
		}

		// Token: 0x06007DC7 RID: 32199
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAngleRepresentation_GetCenterDisplayPosition_08(HandleRef pThis, IntPtr pos);

		/// <summary>
		/// Methods to Set/Get the coordinates of the three points defining
		/// this representation. Note that methods are available for both
		/// display and world coordinates.
		/// </summary>
		// Token: 0x06007DC8 RID: 32200 RVA: 0x000B495B File Offset: 0x000B2B5B
		public virtual void GetCenterDisplayPosition(IntPtr pos)
		{
			vtkAngleRepresentation.vtkAngleRepresentation_GetCenterDisplayPosition_08(base.GetCppThis(), pos);
		}

		// Token: 0x06007DC9 RID: 32201
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAngleRepresentation_GetCenterRepresentation_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the handle representations used for the vtkAngleRepresentation.
		/// </summary>
		// Token: 0x06007DCA RID: 32202 RVA: 0x000B496C File Offset: 0x000B2B6C
		public virtual vtkHandleRepresentation GetCenterRepresentation()
		{
			vtkHandleRepresentation vtkHandleRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAngleRepresentation.vtkAngleRepresentation_GetCenterRepresentation_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHandleRepresentation = (vtkHandleRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHandleRepresentation.Register(null);
				}
			}
			return vtkHandleRepresentation;
		}

		// Token: 0x06007DCB RID: 32203
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAngleRepresentation_GetCenterWorldPosition_10(HandleRef pThis, IntPtr pos);

		/// <summary>
		/// Methods to Set/Get the coordinates of the three points defining
		/// this representation. Note that methods are available for both
		/// display and world coordinates.
		/// </summary>
		// Token: 0x06007DCC RID: 32204 RVA: 0x000B49DB File Offset: 0x000B2BDB
		public virtual void GetCenterWorldPosition(IntPtr pos)
		{
			vtkAngleRepresentation.vtkAngleRepresentation_GetCenterWorldPosition_10(base.GetCppThis(), pos);
		}

		// Token: 0x06007DCD RID: 32205
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAngleRepresentation_GetLabelFormat_11(HandleRef pThis);

		/// <summary>
		/// Specify the format to use for labeling the angle. Note that an empty
		/// string results in no label, or a format string without a "%" character
		/// will not print the angle value.
		/// </summary>
		// Token: 0x06007DCE RID: 32206 RVA: 0x000B49EC File Offset: 0x000B2BEC
		public virtual string GetLabelFormat()
		{
			string s = Marshal.PtrToStringAnsi(vtkAngleRepresentation.vtkAngleRepresentation_GetLabelFormat_11(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06007DCF RID: 32207
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAngleRepresentation_GetNumberOfGenerationsFromBase_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x06007DD0 RID: 32208 RVA: 0x000B4A28 File Offset: 0x000B2C28
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkAngleRepresentation.vtkAngleRepresentation_GetNumberOfGenerationsFromBase_12(base.GetCppThis(), type);
		}

		// Token: 0x06007DD1 RID: 32209
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAngleRepresentation_GetNumberOfGenerationsFromBaseType_13([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x06007DD2 RID: 32210 RVA: 0x000B4A48 File Offset: 0x000B2C48
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkAngleRepresentation.vtkAngleRepresentation_GetNumberOfGenerationsFromBaseType_13(type);
		}

		// Token: 0x06007DD3 RID: 32211
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAngleRepresentation_GetPoint1DisplayPosition_14(HandleRef pThis, IntPtr pos);

		/// <summary>
		/// Methods to Set/Get the coordinates of the three points defining
		/// this representation. Note that methods are available for both
		/// display and world coordinates.
		/// </summary>
		// Token: 0x06007DD4 RID: 32212 RVA: 0x000B4A62 File Offset: 0x000B2C62
		public virtual void GetPoint1DisplayPosition(IntPtr pos)
		{
			vtkAngleRepresentation.vtkAngleRepresentation_GetPoint1DisplayPosition_14(base.GetCppThis(), pos);
		}

		// Token: 0x06007DD5 RID: 32213
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAngleRepresentation_GetPoint1Representation_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the handle representations used for the vtkAngleRepresentation.
		/// </summary>
		// Token: 0x06007DD6 RID: 32214 RVA: 0x000B4A74 File Offset: 0x000B2C74
		public virtual vtkHandleRepresentation GetPoint1Representation()
		{
			vtkHandleRepresentation vtkHandleRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAngleRepresentation.vtkAngleRepresentation_GetPoint1Representation_15(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHandleRepresentation = (vtkHandleRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHandleRepresentation.Register(null);
				}
			}
			return vtkHandleRepresentation;
		}

		// Token: 0x06007DD7 RID: 32215
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAngleRepresentation_GetPoint1WorldPosition_16(HandleRef pThis, IntPtr pos);

		/// <summary>
		/// Methods to Set/Get the coordinates of the three points defining
		/// this representation. Note that methods are available for both
		/// display and world coordinates.
		/// </summary>
		// Token: 0x06007DD8 RID: 32216 RVA: 0x000B4AE3 File Offset: 0x000B2CE3
		public virtual void GetPoint1WorldPosition(IntPtr pos)
		{
			vtkAngleRepresentation.vtkAngleRepresentation_GetPoint1WorldPosition_16(base.GetCppThis(), pos);
		}

		// Token: 0x06007DD9 RID: 32217
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAngleRepresentation_GetPoint2DisplayPosition_17(HandleRef pThis, IntPtr pos);

		/// <summary>
		/// Methods to Set/Get the coordinates of the three points defining
		/// this representation. Note that methods are available for both
		/// display and world coordinates.
		/// </summary>
		// Token: 0x06007DDA RID: 32218 RVA: 0x000B4AF3 File Offset: 0x000B2CF3
		public virtual void GetPoint2DisplayPosition(IntPtr pos)
		{
			vtkAngleRepresentation.vtkAngleRepresentation_GetPoint2DisplayPosition_17(base.GetCppThis(), pos);
		}

		// Token: 0x06007DDB RID: 32219
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAngleRepresentation_GetPoint2Representation_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the handle representations used for the vtkAngleRepresentation.
		/// </summary>
		// Token: 0x06007DDC RID: 32220 RVA: 0x000B4B04 File Offset: 0x000B2D04
		public virtual vtkHandleRepresentation GetPoint2Representation()
		{
			vtkHandleRepresentation vtkHandleRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAngleRepresentation.vtkAngleRepresentation_GetPoint2Representation_18(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHandleRepresentation = (vtkHandleRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHandleRepresentation.Register(null);
				}
			}
			return vtkHandleRepresentation;
		}

		// Token: 0x06007DDD RID: 32221
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAngleRepresentation_GetPoint2WorldPosition_19(HandleRef pThis, IntPtr pos);

		/// <summary>
		/// Methods to Set/Get the coordinates of the three points defining
		/// this representation. Note that methods are available for both
		/// display and world coordinates.
		/// </summary>
		// Token: 0x06007DDE RID: 32222 RVA: 0x000B4B73 File Offset: 0x000B2D73
		public virtual void GetPoint2WorldPosition(IntPtr pos)
		{
			vtkAngleRepresentation.vtkAngleRepresentation_GetPoint2WorldPosition_19(base.GetCppThis(), pos);
		}

		// Token: 0x06007DDF RID: 32223
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAngleRepresentation_GetRay1Visibility_20(HandleRef pThis);

		/// <summary>
		/// Special methods for turning off the rays and arc that define the cone
		/// and arc of the angle.
		/// </summary>
		// Token: 0x06007DE0 RID: 32224 RVA: 0x000B4B84 File Offset: 0x000B2D84
		public virtual int GetRay1Visibility()
		{
			return vtkAngleRepresentation.vtkAngleRepresentation_GetRay1Visibility_20(base.GetCppThis());
		}

		// Token: 0x06007DE1 RID: 32225
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAngleRepresentation_GetRay2Visibility_21(HandleRef pThis);

		/// <summary>
		/// Special methods for turning off the rays and arc that define the cone
		/// and arc of the angle.
		/// </summary>
		// Token: 0x06007DE2 RID: 32226 RVA: 0x000B4BA4 File Offset: 0x000B2DA4
		public virtual int GetRay2Visibility()
		{
			return vtkAngleRepresentation.vtkAngleRepresentation_GetRay2Visibility_21(base.GetCppThis());
		}

		// Token: 0x06007DE3 RID: 32227
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAngleRepresentation_GetScale_22(HandleRef pThis);

		/// <summary>
		/// Set the scale factor from degrees. The label will be defined in terms of the scaled space. For
		/// example, to use radians in the label set the scale factor to pi/180.
		/// </summary>
		// Token: 0x06007DE4 RID: 32228 RVA: 0x000B4BC4 File Offset: 0x000B2DC4
		public virtual double GetScale()
		{
			return vtkAngleRepresentation.vtkAngleRepresentation_GetScale_22(base.GetCppThis());
		}

		// Token: 0x06007DE5 RID: 32229
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAngleRepresentation_GetTolerance_23(HandleRef pThis);

		/// <summary>
		/// The tolerance representing the distance to the representation (in
		/// pixels) in which the cursor is considered near enough to the end points
		/// of the representation to be active.
		/// </summary>
		// Token: 0x06007DE6 RID: 32230 RVA: 0x000B4BE4 File Offset: 0x000B2DE4
		public virtual int GetTolerance()
		{
			return vtkAngleRepresentation.vtkAngleRepresentation_GetTolerance_23(base.GetCppThis());
		}

		// Token: 0x06007DE7 RID: 32231
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAngleRepresentation_GetToleranceMaxValue_24(HandleRef pThis);

		/// <summary>
		/// The tolerance representing the distance to the representation (in
		/// pixels) in which the cursor is considered near enough to the end points
		/// of the representation to be active.
		/// </summary>
		// Token: 0x06007DE8 RID: 32232 RVA: 0x000B4C04 File Offset: 0x000B2E04
		public virtual int GetToleranceMaxValue()
		{
			return vtkAngleRepresentation.vtkAngleRepresentation_GetToleranceMaxValue_24(base.GetCppThis());
		}

		// Token: 0x06007DE9 RID: 32233
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAngleRepresentation_GetToleranceMinValue_25(HandleRef pThis);

		/// <summary>
		/// The tolerance representing the distance to the representation (in
		/// pixels) in which the cursor is considered near enough to the end points
		/// of the representation to be active.
		/// </summary>
		// Token: 0x06007DEA RID: 32234 RVA: 0x000B4C24 File Offset: 0x000B2E24
		public virtual int GetToleranceMinValue()
		{
			return vtkAngleRepresentation.vtkAngleRepresentation_GetToleranceMinValue_25(base.GetCppThis());
		}

		// Token: 0x06007DEB RID: 32235
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAngleRepresentation_InstantiateHandleRepresentation_26(HandleRef pThis);

		/// <summary>
		/// This method is used to specify the type of handle representation to use
		/// for the three internal vtkHandleWidgets within vtkAngleRepresentation.
		/// To use this method, create a dummy vtkHandleRepresentation (or
		/// subclass), and then invoke this method with this dummy. Then the
		/// vtkAngleRepresentation uses this dummy to clone three
		/// vtkHandleRepresentations of the same type. Make sure you set the handle
		/// representation before the widget is enabled. (The method
		/// InstantiateHandleRepresentation() is invoked by the vtkAngle widget.)
		/// </summary>
		// Token: 0x06007DEC RID: 32236 RVA: 0x000B4C43 File Offset: 0x000B2E43
		public void InstantiateHandleRepresentation()
		{
			vtkAngleRepresentation.vtkAngleRepresentation_InstantiateHandleRepresentation_26(base.GetCppThis());
		}

		// Token: 0x06007DED RID: 32237
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAngleRepresentation_IsA_27(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x06007DEE RID: 32238 RVA: 0x000B4C54 File Offset: 0x000B2E54
		public override int IsA(string type)
		{
			return vtkAngleRepresentation.vtkAngleRepresentation_IsA_27(base.GetCppThis(), type);
		}

		// Token: 0x06007DEF RID: 32239
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAngleRepresentation_IsTypeOf_28([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x06007DF0 RID: 32240 RVA: 0x000B4C74 File Offset: 0x000B2E74
		public new static int IsTypeOf(string type)
		{
			return vtkAngleRepresentation.vtkAngleRepresentation_IsTypeOf_28(type);
		}

		// Token: 0x06007DF1 RID: 32241
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAngleRepresentation_NewInstance_29(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x06007DF2 RID: 32242 RVA: 0x000B4C90 File Offset: 0x000B2E90
		public new vtkAngleRepresentation NewInstance()
		{
			vtkAngleRepresentation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAngleRepresentation.vtkAngleRepresentation_NewInstance_29(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAngleRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06007DF3 RID: 32243
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAngleRepresentation_Ray1VisibilityOff_30(HandleRef pThis);

		/// <summary>
		/// Special methods for turning off the rays and arc that define the cone
		/// and arc of the angle.
		/// </summary>
		// Token: 0x06007DF4 RID: 32244 RVA: 0x000B4CEA File Offset: 0x000B2EEA
		public virtual void Ray1VisibilityOff()
		{
			vtkAngleRepresentation.vtkAngleRepresentation_Ray1VisibilityOff_30(base.GetCppThis());
		}

		// Token: 0x06007DF5 RID: 32245
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAngleRepresentation_Ray1VisibilityOn_31(HandleRef pThis);

		/// <summary>
		/// Special methods for turning off the rays and arc that define the cone
		/// and arc of the angle.
		/// </summary>
		// Token: 0x06007DF6 RID: 32246 RVA: 0x000B4CF9 File Offset: 0x000B2EF9
		public virtual void Ray1VisibilityOn()
		{
			vtkAngleRepresentation.vtkAngleRepresentation_Ray1VisibilityOn_31(base.GetCppThis());
		}

		// Token: 0x06007DF7 RID: 32247
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAngleRepresentation_Ray2VisibilityOff_32(HandleRef pThis);

		/// <summary>
		/// Special methods for turning off the rays and arc that define the cone
		/// and arc of the angle.
		/// </summary>
		// Token: 0x06007DF8 RID: 32248 RVA: 0x000B4D08 File Offset: 0x000B2F08
		public virtual void Ray2VisibilityOff()
		{
			vtkAngleRepresentation.vtkAngleRepresentation_Ray2VisibilityOff_32(base.GetCppThis());
		}

		// Token: 0x06007DF9 RID: 32249
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAngleRepresentation_Ray2VisibilityOn_33(HandleRef pThis);

		/// <summary>
		/// Special methods for turning off the rays and arc that define the cone
		/// and arc of the angle.
		/// </summary>
		// Token: 0x06007DFA RID: 32250 RVA: 0x000B4D17 File Offset: 0x000B2F17
		public virtual void Ray2VisibilityOn()
		{
			vtkAngleRepresentation.vtkAngleRepresentation_Ray2VisibilityOn_33(base.GetCppThis());
		}

		// Token: 0x06007DFB RID: 32251
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAngleRepresentation_SafeDownCast_34(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x06007DFC RID: 32252 RVA: 0x000B4D28 File Offset: 0x000B2F28
		public new static vtkAngleRepresentation SafeDownCast(vtkObjectBase o)
		{
			vtkAngleRepresentation vtkAngleRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAngleRepresentation.vtkAngleRepresentation_SafeDownCast_34((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAngleRepresentation = (vtkAngleRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAngleRepresentation.Register(null);
				}
			}
			return vtkAngleRepresentation;
		}

		// Token: 0x06007DFD RID: 32253
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAngleRepresentation_SetArcVisibility_35(HandleRef pThis, int _arg);

		/// <summary>
		/// Special methods for turning off the rays and arc that define the cone
		/// and arc of the angle.
		/// </summary>
		// Token: 0x06007DFE RID: 32254 RVA: 0x000B4DA7 File Offset: 0x000B2FA7
		public virtual void SetArcVisibility(int _arg)
		{
			vtkAngleRepresentation.vtkAngleRepresentation_SetArcVisibility_35(base.GetCppThis(), _arg);
		}

		// Token: 0x06007DFF RID: 32255
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAngleRepresentation_SetCenterDisplayPosition_36(HandleRef pThis, IntPtr pos);

		/// <summary>
		/// Methods to Set/Get the coordinates of the three points defining
		/// this representation. Note that methods are available for both
		/// display and world coordinates.
		/// </summary>
		// Token: 0x06007E00 RID: 32256 RVA: 0x000B4DB7 File Offset: 0x000B2FB7
		public virtual void SetCenterDisplayPosition(IntPtr pos)
		{
			vtkAngleRepresentation.vtkAngleRepresentation_SetCenterDisplayPosition_36(base.GetCppThis(), pos);
		}

		// Token: 0x06007E01 RID: 32257
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAngleRepresentation_SetHandleRepresentation_37(HandleRef pThis, HandleRef handle);

		/// <summary>
		/// This method is used to specify the type of handle representation to use
		/// for the three internal vtkHandleWidgets within vtkAngleRepresentation.
		/// To use this method, create a dummy vtkHandleRepresentation (or
		/// subclass), and then invoke this method with this dummy. Then the
		/// vtkAngleRepresentation uses this dummy to clone three
		/// vtkHandleRepresentations of the same type. Make sure you set the handle
		/// representation before the widget is enabled. (The method
		/// InstantiateHandleRepresentation() is invoked by the vtkAngle widget.)
		/// </summary>
		// Token: 0x06007E02 RID: 32258 RVA: 0x000B4DC8 File Offset: 0x000B2FC8
		public void SetHandleRepresentation(vtkHandleRepresentation handle)
		{
			vtkAngleRepresentation.vtkAngleRepresentation_SetHandleRepresentation_37(base.GetCppThis(), (handle == null) ? default(HandleRef) : handle.GetCppThis());
		}

		// Token: 0x06007E03 RID: 32259
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAngleRepresentation_SetLabelFormat_38(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Specify the format to use for labeling the angle. Note that an empty
		/// string results in no label, or a format string without a "%" character
		/// will not print the angle value.
		/// </summary>
		// Token: 0x06007E04 RID: 32260 RVA: 0x000B4DF7 File Offset: 0x000B2FF7
		public virtual void SetLabelFormat(string _arg)
		{
			vtkAngleRepresentation.vtkAngleRepresentation_SetLabelFormat_38(base.GetCppThis(), _arg);
		}

		// Token: 0x06007E05 RID: 32261
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAngleRepresentation_SetPoint1DisplayPosition_39(HandleRef pThis, IntPtr pos);

		/// <summary>
		/// Methods to Set/Get the coordinates of the three points defining
		/// this representation. Note that methods are available for both
		/// display and world coordinates.
		/// </summary>
		// Token: 0x06007E06 RID: 32262 RVA: 0x000B4E07 File Offset: 0x000B3007
		public virtual void SetPoint1DisplayPosition(IntPtr pos)
		{
			vtkAngleRepresentation.vtkAngleRepresentation_SetPoint1DisplayPosition_39(base.GetCppThis(), pos);
		}

		// Token: 0x06007E07 RID: 32263
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAngleRepresentation_SetPoint2DisplayPosition_40(HandleRef pThis, IntPtr pos);

		/// <summary>
		/// Methods to Set/Get the coordinates of the three points defining
		/// this representation. Note that methods are available for both
		/// display and world coordinates.
		/// </summary>
		// Token: 0x06007E08 RID: 32264 RVA: 0x000B4E17 File Offset: 0x000B3017
		public virtual void SetPoint2DisplayPosition(IntPtr pos)
		{
			vtkAngleRepresentation.vtkAngleRepresentation_SetPoint2DisplayPosition_40(base.GetCppThis(), pos);
		}

		// Token: 0x06007E09 RID: 32265
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAngleRepresentation_SetRay1Visibility_41(HandleRef pThis, int _arg);

		/// <summary>
		/// Special methods for turning off the rays and arc that define the cone
		/// and arc of the angle.
		/// </summary>
		// Token: 0x06007E0A RID: 32266 RVA: 0x000B4E27 File Offset: 0x000B3027
		public virtual void SetRay1Visibility(int _arg)
		{
			vtkAngleRepresentation.vtkAngleRepresentation_SetRay1Visibility_41(base.GetCppThis(), _arg);
		}

		// Token: 0x06007E0B RID: 32267
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAngleRepresentation_SetRay2Visibility_42(HandleRef pThis, int _arg);

		/// <summary>
		/// Special methods for turning off the rays and arc that define the cone
		/// and arc of the angle.
		/// </summary>
		// Token: 0x06007E0C RID: 32268 RVA: 0x000B4E37 File Offset: 0x000B3037
		public virtual void SetRay2Visibility(int _arg)
		{
			vtkAngleRepresentation.vtkAngleRepresentation_SetRay2Visibility_42(base.GetCppThis(), _arg);
		}

		// Token: 0x06007E0D RID: 32269
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAngleRepresentation_SetRenderer_43(HandleRef pThis, HandleRef ren);

		/// <summary>
		/// These are methods that satisfy vtkWidgetRepresentation's API.
		/// </summary>
		// Token: 0x06007E0E RID: 32270 RVA: 0x000B4E48 File Offset: 0x000B3048
		public override void SetRenderer(vtkRenderer ren)
		{
			vtkAngleRepresentation.vtkAngleRepresentation_SetRenderer_43(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis());
		}

		// Token: 0x06007E0F RID: 32271
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAngleRepresentation_SetScale_44(HandleRef pThis, double _arg);

		/// <summary>
		/// Set the scale factor from degrees. The label will be defined in terms of the scaled space. For
		/// example, to use radians in the label set the scale factor to pi/180.
		/// </summary>
		// Token: 0x06007E10 RID: 32272 RVA: 0x000B4E77 File Offset: 0x000B3077
		public virtual void SetScale(double _arg)
		{
			vtkAngleRepresentation.vtkAngleRepresentation_SetScale_44(base.GetCppThis(), _arg);
		}

		// Token: 0x06007E11 RID: 32273
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAngleRepresentation_SetTolerance_45(HandleRef pThis, int _arg);

		/// <summary>
		/// The tolerance representing the distance to the representation (in
		/// pixels) in which the cursor is considered near enough to the end points
		/// of the representation to be active.
		/// </summary>
		// Token: 0x06007E12 RID: 32274 RVA: 0x000B4E87 File Offset: 0x000B3087
		public virtual void SetTolerance(int _arg)
		{
			vtkAngleRepresentation.vtkAngleRepresentation_SetTolerance_45(base.GetCppThis(), _arg);
		}

		// Token: 0x06007E13 RID: 32275
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAngleRepresentation_StartWidgetInteraction_46(HandleRef pThis, IntPtr e);

		/// <summary>
		/// These are methods that satisfy vtkWidgetRepresentation's API.
		/// </summary>
		// Token: 0x06007E14 RID: 32276 RVA: 0x000B4E97 File Offset: 0x000B3097
		public override void StartWidgetInteraction(IntPtr e)
		{
			vtkAngleRepresentation.vtkAngleRepresentation_StartWidgetInteraction_46(base.GetCppThis(), e);
		}

		// Token: 0x06007E15 RID: 32277
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAngleRepresentation_WidgetInteraction_47(HandleRef pThis, IntPtr e);

		/// <summary>
		/// These are methods that satisfy vtkWidgetRepresentation's API.
		/// </summary>
		// Token: 0x06007E16 RID: 32278 RVA: 0x000B4EA7 File Offset: 0x000B30A7
		public override void WidgetInteraction(IntPtr e)
		{
			vtkAngleRepresentation.vtkAngleRepresentation_WidgetInteraction_47(base.GetCppThis(), e);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000A9F RID: 2719
		public new const string MRFullTypeName = "Kitware.VTK.vtkAngleRepresentation";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000AA0 RID: 2720
		public new static readonly string MRClassNameKey = "class vtkAngleRepresentation";

		/// <summary>
		/// Special methods for turning off the rays and arc that define the cone
		/// and arc of the angle.
		/// </summary>
		// Token: 0x020002B8 RID: 696
		public enum NearCenter_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x04000AA2 RID: 2722
			NearCenter = 2,
			/// <summary>enum member</summary>
			// Token: 0x04000AA3 RID: 2723
			NearP1 = 1,
			/// <summary>enum member</summary>
			// Token: 0x04000AA4 RID: 2724
			NearP2 = 3,
			/// <summary>enum member</summary>
			// Token: 0x04000AA5 RID: 2725
			Outside = 0
		}
	}
}
