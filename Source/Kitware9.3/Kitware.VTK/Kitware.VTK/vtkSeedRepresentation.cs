using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkSeedRepresentation
	/// </summary>
	/// <remarks>
	///    represent the vtkSeedWidget
	///
	/// The vtkSeedRepresentation is a superclass for classes representing the
	/// vtkSeedWidget. This representation consists of one or more handles
	/// (vtkHandleRepresentation) which are used to place and manipulate the
	/// points defining the collection of seeds.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkSeedWidget vtkHandleRepresentation vtkSeedRepresentation
	/// </seealso>
	// Token: 0x02000371 RID: 881
	public class vtkSeedRepresentation : vtkWidgetRepresentation
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06009FDB RID: 40923 RVA: 0x000E2D87 File Offset: 0x000E0F87
		static vtkSeedRepresentation()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSeedRepresentation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSeedRepresentation"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06009FDC RID: 40924 RVA: 0x000E2DAF File Offset: 0x000E0FAF
		public vtkSeedRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06009FDD RID: 40925
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSeedRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate class.
		/// </summary>
		// Token: 0x06009FDE RID: 40926 RVA: 0x000E2DC0 File Offset: 0x000E0FC0
		public new static vtkSeedRepresentation New()
		{
			vtkSeedRepresentation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSeedRepresentation.vtkSeedRepresentation_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSeedRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate class.
		/// </summary>
		// Token: 0x06009FDF RID: 40927 RVA: 0x000E2E14 File Offset: 0x000E1014
		public vtkSeedRepresentation() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkSeedRepresentation.vtkSeedRepresentation_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06009FE0 RID: 40928 RVA: 0x000E2E58 File Offset: 0x000E1058
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06009FE1 RID: 40929
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSeedRepresentation_BuildRepresentation_01(HandleRef pThis);

		/// <summary>
		/// These are methods that satisfy vtkWidgetRepresentation's API.
		/// </summary>
		// Token: 0x06009FE2 RID: 40930 RVA: 0x000E2E63 File Offset: 0x000E1063
		public override void BuildRepresentation()
		{
			vtkSeedRepresentation.vtkSeedRepresentation_BuildRepresentation_01(base.GetCppThis());
		}

		// Token: 0x06009FE3 RID: 40931
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSeedRepresentation_ComputeInteractionState_02(HandleRef pThis, int X, int Y, int modify);

		/// <summary>
		/// These are methods that satisfy vtkWidgetRepresentation's API.
		/// </summary>
		// Token: 0x06009FE4 RID: 40932 RVA: 0x000E2E74 File Offset: 0x000E1074
		public override int ComputeInteractionState(int X, int Y, int modify)
		{
			return vtkSeedRepresentation.vtkSeedRepresentation_ComputeInteractionState_02(base.GetCppThis(), X, Y, modify);
		}

		// Token: 0x06009FE5 RID: 40933
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSeedRepresentation_CreateHandle_03(HandleRef pThis, IntPtr e);

		/// <summary>
		/// These are methods specific to vtkSeedRepresentation and which are
		/// invoked from vtkSeedWidget.
		/// </summary>
		// Token: 0x06009FE6 RID: 40934 RVA: 0x000E2E98 File Offset: 0x000E1098
		public virtual int CreateHandle(IntPtr e)
		{
			return vtkSeedRepresentation.vtkSeedRepresentation_CreateHandle_03(base.GetCppThis(), e);
		}

		// Token: 0x06009FE7 RID: 40935
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSeedRepresentation_GetActiveHandle_04(HandleRef pThis);

		/// <summary>
		/// These are methods specific to vtkSeedRepresentation and which are
		/// invoked from vtkSeedWidget.
		/// </summary>
		// Token: 0x06009FE8 RID: 40936 RVA: 0x000E2EB8 File Offset: 0x000E10B8
		public virtual int GetActiveHandle()
		{
			return vtkSeedRepresentation.vtkSeedRepresentation_GetActiveHandle_04(base.GetCppThis());
		}

		// Token: 0x06009FE9 RID: 40937
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSeedRepresentation_GetActors_05(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// These are methods that satisfy vtkWidgetRepresentation's API.
		/// </summary>
		// Token: 0x06009FEA RID: 40938 RVA: 0x000E2ED8 File Offset: 0x000E10D8
		public override void GetActors(vtkPropCollection arg0)
		{
			vtkSeedRepresentation.vtkSeedRepresentation_GetActors_05(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06009FEB RID: 40939
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSeedRepresentation_GetHandleRepresentation_06(HandleRef pThis, uint num, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the handle representations used for a particular seed. A side effect of
		/// this method is that it will create a handle representation in the list of
		/// representations if one has not yet been created.
		/// </summary>
		// Token: 0x06009FEC RID: 40940 RVA: 0x000E2F08 File Offset: 0x000E1108
		public vtkHandleRepresentation GetHandleRepresentation(uint num)
		{
			vtkHandleRepresentation vtkHandleRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSeedRepresentation.vtkSeedRepresentation_GetHandleRepresentation_06(base.GetCppThis(), num, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06009FED RID: 40941
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSeedRepresentation_GetHandleRepresentation_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Returns the model HandleRepresentation.
		/// </summary>
		// Token: 0x06009FEE RID: 40942 RVA: 0x000E2F78 File Offset: 0x000E1178
		public vtkHandleRepresentation GetHandleRepresentation()
		{
			vtkHandleRepresentation vtkHandleRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSeedRepresentation.vtkSeedRepresentation_GetHandleRepresentation_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06009FEF RID: 40943
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSeedRepresentation_GetNumberOfGenerationsFromBase_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x06009FF0 RID: 40944 RVA: 0x000E2FE8 File Offset: 0x000E11E8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkSeedRepresentation.vtkSeedRepresentation_GetNumberOfGenerationsFromBase_08(base.GetCppThis(), type);
		}

		// Token: 0x06009FF1 RID: 40945
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSeedRepresentation_GetNumberOfGenerationsFromBaseType_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x06009FF2 RID: 40946 RVA: 0x000E3008 File Offset: 0x000E1208
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkSeedRepresentation.vtkSeedRepresentation_GetNumberOfGenerationsFromBaseType_09(type);
		}

		// Token: 0x06009FF3 RID: 40947
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSeedRepresentation_GetNumberOfSeeds_10(HandleRef pThis);

		/// <summary>
		/// Return the number of seeds (or handles) that have been created.
		/// </summary>
		// Token: 0x06009FF4 RID: 40948 RVA: 0x000E3024 File Offset: 0x000E1224
		public int GetNumberOfSeeds()
		{
			return vtkSeedRepresentation.vtkSeedRepresentation_GetNumberOfSeeds_10(base.GetCppThis());
		}

		// Token: 0x06009FF5 RID: 40949
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSeedRepresentation_GetSeedDisplayPosition_11(HandleRef pThis, uint seedNum, IntPtr pos);

		/// <summary>
		/// Methods to Set/Get the coordinates of seed points defining
		/// this representation. Note that methods are available for both
		/// display and world coordinates. The seeds are accessed by a seed
		/// number.
		/// </summary>
		// Token: 0x06009FF6 RID: 40950 RVA: 0x000E3043 File Offset: 0x000E1243
		public virtual void GetSeedDisplayPosition(uint seedNum, IntPtr pos)
		{
			vtkSeedRepresentation.vtkSeedRepresentation_GetSeedDisplayPosition_11(base.GetCppThis(), seedNum, pos);
		}

		// Token: 0x06009FF7 RID: 40951
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSeedRepresentation_GetSeedWorldPosition_12(HandleRef pThis, uint seedNum, IntPtr pos);

		/// <summary>
		/// Methods to Set/Get the coordinates of seed points defining
		/// this representation. Note that methods are available for both
		/// display and world coordinates. The seeds are accessed by a seed
		/// number.
		/// </summary>
		// Token: 0x06009FF8 RID: 40952 RVA: 0x000E3054 File Offset: 0x000E1254
		public virtual void GetSeedWorldPosition(uint seedNum, IntPtr pos)
		{
			vtkSeedRepresentation.vtkSeedRepresentation_GetSeedWorldPosition_12(base.GetCppThis(), seedNum, pos);
		}

		// Token: 0x06009FF9 RID: 40953
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSeedRepresentation_GetTolerance_13(HandleRef pThis);

		/// <summary>
		/// The tolerance representing the distance to the widget (in pixels) in
		/// which the cursor is considered near enough to the seed points of
		/// the widget to be active.
		/// </summary>
		// Token: 0x06009FFA RID: 40954 RVA: 0x000E3068 File Offset: 0x000E1268
		public virtual int GetTolerance()
		{
			return vtkSeedRepresentation.vtkSeedRepresentation_GetTolerance_13(base.GetCppThis());
		}

		// Token: 0x06009FFB RID: 40955
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSeedRepresentation_GetToleranceMaxValue_14(HandleRef pThis);

		/// <summary>
		/// The tolerance representing the distance to the widget (in pixels) in
		/// which the cursor is considered near enough to the seed points of
		/// the widget to be active.
		/// </summary>
		// Token: 0x06009FFC RID: 40956 RVA: 0x000E3088 File Offset: 0x000E1288
		public virtual int GetToleranceMaxValue()
		{
			return vtkSeedRepresentation.vtkSeedRepresentation_GetToleranceMaxValue_14(base.GetCppThis());
		}

		// Token: 0x06009FFD RID: 40957
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSeedRepresentation_GetToleranceMinValue_15(HandleRef pThis);

		/// <summary>
		/// The tolerance representing the distance to the widget (in pixels) in
		/// which the cursor is considered near enough to the seed points of
		/// the widget to be active.
		/// </summary>
		// Token: 0x06009FFE RID: 40958 RVA: 0x000E30A8 File Offset: 0x000E12A8
		public virtual int GetToleranceMinValue()
		{
			return vtkSeedRepresentation.vtkSeedRepresentation_GetToleranceMinValue_15(base.GetCppThis());
		}

		// Token: 0x06009FFF RID: 40959
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSeedRepresentation_IsA_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x0600A000 RID: 40960 RVA: 0x000E30C8 File Offset: 0x000E12C8
		public override int IsA(string type)
		{
			return vtkSeedRepresentation.vtkSeedRepresentation_IsA_16(base.GetCppThis(), type);
		}

		// Token: 0x0600A001 RID: 40961
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSeedRepresentation_IsTypeOf_17([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x0600A002 RID: 40962 RVA: 0x000E30E8 File Offset: 0x000E12E8
		public new static int IsTypeOf(string type)
		{
			return vtkSeedRepresentation.vtkSeedRepresentation_IsTypeOf_17(type);
		}

		// Token: 0x0600A003 RID: 40963
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSeedRepresentation_NewInstance_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x0600A004 RID: 40964 RVA: 0x000E3104 File Offset: 0x000E1304
		public new vtkSeedRepresentation NewInstance()
		{
			vtkSeedRepresentation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSeedRepresentation.vtkSeedRepresentation_NewInstance_19(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSeedRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600A005 RID: 40965
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSeedRepresentation_RemoveActiveHandle_20(HandleRef pThis);

		/// <summary>
		/// These are methods specific to vtkSeedRepresentation and which are
		/// invoked from vtkSeedWidget.
		/// </summary>
		// Token: 0x0600A006 RID: 40966 RVA: 0x000E315E File Offset: 0x000E135E
		public virtual void RemoveActiveHandle()
		{
			vtkSeedRepresentation.vtkSeedRepresentation_RemoveActiveHandle_20(base.GetCppThis());
		}

		// Token: 0x0600A007 RID: 40967
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSeedRepresentation_RemoveHandle_21(HandleRef pThis, int n);

		/// <summary>
		/// Remove the nth handle.
		/// </summary>
		// Token: 0x0600A008 RID: 40968 RVA: 0x000E316D File Offset: 0x000E136D
		public virtual void RemoveHandle(int n)
		{
			vtkSeedRepresentation.vtkSeedRepresentation_RemoveHandle_21(base.GetCppThis(), n);
		}

		// Token: 0x0600A009 RID: 40969
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSeedRepresentation_RemoveLastHandle_22(HandleRef pThis);

		/// <summary>
		/// These are methods specific to vtkSeedRepresentation and which are
		/// invoked from vtkSeedWidget.
		/// </summary>
		// Token: 0x0600A00A RID: 40970 RVA: 0x000E317D File Offset: 0x000E137D
		public virtual void RemoveLastHandle()
		{
			vtkSeedRepresentation.vtkSeedRepresentation_RemoveLastHandle_22(base.GetCppThis());
		}

		// Token: 0x0600A00B RID: 40971
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSeedRepresentation_SafeDownCast_23(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x0600A00C RID: 40972 RVA: 0x000E318C File Offset: 0x000E138C
		public new static vtkSeedRepresentation SafeDownCast(vtkObjectBase o)
		{
			vtkSeedRepresentation vtkSeedRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSeedRepresentation.vtkSeedRepresentation_SafeDownCast_23((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSeedRepresentation = (vtkSeedRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSeedRepresentation.Register(null);
				}
			}
			return vtkSeedRepresentation;
		}

		// Token: 0x0600A00D RID: 40973
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSeedRepresentation_SetActiveHandle_24(HandleRef pThis, int handleId);

		/// <summary>
		/// These are methods specific to vtkSeedRepresentation and which are
		/// invoked from vtkSeedWidget.
		/// </summary>
		// Token: 0x0600A00E RID: 40974 RVA: 0x000E320B File Offset: 0x000E140B
		public virtual void SetActiveHandle(int handleId)
		{
			vtkSeedRepresentation.vtkSeedRepresentation_SetActiveHandle_24(base.GetCppThis(), handleId);
		}

		// Token: 0x0600A00F RID: 40975
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSeedRepresentation_SetHandleRepresentation_25(HandleRef pThis, HandleRef handle);

		/// <summary>
		/// This method is used to specify the type of handle representation to use
		/// for the internal vtkHandleWidgets within vtkSeedWidget.  To use this
		/// method, create a dummy vtkHandleWidget (or subclass), and then invoke
		/// this method with this dummy. Then the vtkSeedRepresentation uses this
		/// dummy to clone vtkHandleWidgets of the same type. Make sure you set the
		/// handle representation before the widget is enabled.
		/// </summary>
		// Token: 0x0600A010 RID: 40976 RVA: 0x000E321C File Offset: 0x000E141C
		public void SetHandleRepresentation(vtkHandleRepresentation handle)
		{
			vtkSeedRepresentation.vtkSeedRepresentation_SetHandleRepresentation_25(base.GetCppThis(), (handle == null) ? default(HandleRef) : handle.GetCppThis());
		}

		// Token: 0x0600A011 RID: 40977
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSeedRepresentation_SetSeedDisplayPosition_26(HandleRef pThis, uint seedNum, IntPtr pos);

		/// <summary>
		/// Methods to Set/Get the coordinates of seed points defining
		/// this representation. Note that methods are available for both
		/// display and world coordinates. The seeds are accessed by a seed
		/// number.
		/// </summary>
		// Token: 0x0600A012 RID: 40978 RVA: 0x000E324B File Offset: 0x000E144B
		public virtual void SetSeedDisplayPosition(uint seedNum, IntPtr pos)
		{
			vtkSeedRepresentation.vtkSeedRepresentation_SetSeedDisplayPosition_26(base.GetCppThis(), seedNum, pos);
		}

		// Token: 0x0600A013 RID: 40979
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSeedRepresentation_SetSeedWorldPosition_27(HandleRef pThis, uint seedNum, IntPtr pos);

		/// <summary>
		/// Methods to Set/Get the coordinates of seed points defining
		/// this representation. Note that methods are available for both
		/// display and world coordinates. The seeds are accessed by a seed
		/// number.
		/// </summary>
		// Token: 0x0600A014 RID: 40980 RVA: 0x000E325C File Offset: 0x000E145C
		public virtual void SetSeedWorldPosition(uint seedNum, IntPtr pos)
		{
			vtkSeedRepresentation.vtkSeedRepresentation_SetSeedWorldPosition_27(base.GetCppThis(), seedNum, pos);
		}

		// Token: 0x0600A015 RID: 40981
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSeedRepresentation_SetTolerance_28(HandleRef pThis, int _arg);

		/// <summary>
		/// The tolerance representing the distance to the widget (in pixels) in
		/// which the cursor is considered near enough to the seed points of
		/// the widget to be active.
		/// </summary>
		// Token: 0x0600A016 RID: 40982 RVA: 0x000E326D File Offset: 0x000E146D
		public virtual void SetTolerance(int _arg)
		{
			vtkSeedRepresentation.vtkSeedRepresentation_SetTolerance_28(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000CE8 RID: 3304
		public new const string MRFullTypeName = "Kitware.VTK.vtkSeedRepresentation";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000CE9 RID: 3305
		public new static readonly string MRClassNameKey = "class vtkSeedRepresentation";

		/// <summary>
		/// The tolerance representing the distance to the widget (in pixels) in
		/// which the cursor is considered near enough to the seed points of
		/// the widget to be active.
		/// </summary>
		// Token: 0x02000372 RID: 882
		public enum NearSeed_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x04000CEB RID: 3307
			NearSeed = 1,
			/// <summary>enum member</summary>
			// Token: 0x04000CEC RID: 3308
			Outside = 0
		}
	}
}
