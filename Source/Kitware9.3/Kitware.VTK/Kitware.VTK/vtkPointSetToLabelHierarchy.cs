using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPointSetToLabelHierarchy
	/// </summary>
	/// <remarks>
	///    build a label hierarchy for a graph or point set.
	///
	///
	///
	/// Every point in the input vtkPoints object is taken to be an
	/// anchor point for a label. Statistics on the input points
	/// are used to subdivide an octree referencing the points
	/// until the points each octree node contains have a variance
	/// close to the node size and a limited population (&lt; 100).
	/// </remarks>
	// Token: 0x020000F8 RID: 248
	public class vtkPointSetToLabelHierarchy : vtkLabelHierarchyAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060032E9 RID: 13033 RVA: 0x0004AE44 File Offset: 0x00049044
		static vtkPointSetToLabelHierarchy()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPointSetToLabelHierarchy.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPointSetToLabelHierarchy"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060032EA RID: 13034 RVA: 0x0004AE6C File Offset: 0x0004906C
		public vtkPointSetToLabelHierarchy(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060032EB RID: 13035
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointSetToLabelHierarchy_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060032EC RID: 13036 RVA: 0x0004AE7C File Offset: 0x0004907C
		public new static vtkPointSetToLabelHierarchy New()
		{
			vtkPointSetToLabelHierarchy result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPointSetToLabelHierarchy.vtkPointSetToLabelHierarchy_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPointSetToLabelHierarchy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060032ED RID: 13037 RVA: 0x0004AED0 File Offset: 0x000490D0
		public vtkPointSetToLabelHierarchy() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPointSetToLabelHierarchy.vtkPointSetToLabelHierarchy_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060032EE RID: 13038 RVA: 0x0004AF14 File Offset: 0x00049114
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060032EF RID: 13039
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointSetToLabelHierarchy_GetBoundedSizeArrayName_01(HandleRef pThis);

		/// <summary>
		/// Set/get the maximum text width (in world coordinates) array name.
		/// </summary>
		// Token: 0x060032F0 RID: 13040 RVA: 0x0004AF20 File Offset: 0x00049120
		public virtual string GetBoundedSizeArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkPointSetToLabelHierarchy.vtkPointSetToLabelHierarchy_GetBoundedSizeArrayName_01(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060032F1 RID: 13041
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointSetToLabelHierarchy_GetIconIndexArrayName_02(HandleRef pThis);

		/// <summary>
		/// Set/get the icon index array name.
		/// </summary>
		// Token: 0x060032F2 RID: 13042 RVA: 0x0004AF5C File Offset: 0x0004915C
		public virtual string GetIconIndexArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkPointSetToLabelHierarchy.vtkPointSetToLabelHierarchy_GetIconIndexArrayName_02(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060032F3 RID: 13043
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointSetToLabelHierarchy_GetLabelArrayName_03(HandleRef pThis);

		/// <summary>
		/// Set/get the label array name.
		/// </summary>
		// Token: 0x060032F4 RID: 13044 RVA: 0x0004AF98 File Offset: 0x00049198
		public virtual string GetLabelArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkPointSetToLabelHierarchy.vtkPointSetToLabelHierarchy_GetLabelArrayName_03(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060032F5 RID: 13045
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointSetToLabelHierarchy_GetMaximumDepth_04(HandleRef pThis);

		/// <summary>
		/// Set/get the maximum tree depth in the output hierarchy.
		/// </summary>
		// Token: 0x060032F6 RID: 13046 RVA: 0x0004AFD4 File Offset: 0x000491D4
		public virtual int GetMaximumDepth()
		{
			return vtkPointSetToLabelHierarchy.vtkPointSetToLabelHierarchy_GetMaximumDepth_04(base.GetCppThis());
		}

		// Token: 0x060032F7 RID: 13047
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPointSetToLabelHierarchy_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060032F8 RID: 13048 RVA: 0x0004AFF4 File Offset: 0x000491F4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPointSetToLabelHierarchy.vtkPointSetToLabelHierarchy_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x060032F9 RID: 13049
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPointSetToLabelHierarchy_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060032FA RID: 13050 RVA: 0x0004B014 File Offset: 0x00049214
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPointSetToLabelHierarchy.vtkPointSetToLabelHierarchy_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x060032FB RID: 13051
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointSetToLabelHierarchy_GetOrientationArrayName_07(HandleRef pThis);

		/// <summary>
		/// Set/get the text orientation array name.
		/// </summary>
		// Token: 0x060032FC RID: 13052 RVA: 0x0004B030 File Offset: 0x00049230
		public virtual string GetOrientationArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkPointSetToLabelHierarchy.vtkPointSetToLabelHierarchy_GetOrientationArrayName_07(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060032FD RID: 13053
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointSetToLabelHierarchy_GetPriorityArrayName_08(HandleRef pThis);

		/// <summary>
		/// Set/get the priority array name.
		/// </summary>
		// Token: 0x060032FE RID: 13054 RVA: 0x0004B06C File Offset: 0x0004926C
		public virtual string GetPriorityArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkPointSetToLabelHierarchy.vtkPointSetToLabelHierarchy_GetPriorityArrayName_08(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060032FF RID: 13055
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointSetToLabelHierarchy_GetSizeArrayName_09(HandleRef pThis);

		/// <summary>
		/// Set/get the priority array name.
		/// </summary>
		// Token: 0x06003300 RID: 13056 RVA: 0x0004B0A8 File Offset: 0x000492A8
		public virtual string GetSizeArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkPointSetToLabelHierarchy.vtkPointSetToLabelHierarchy_GetSizeArrayName_09(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06003301 RID: 13057
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointSetToLabelHierarchy_GetTargetLabelCount_10(HandleRef pThis);

		/// <summary>
		/// Set/get the "ideal" number of labels to associate with each node in the output hierarchy.
		/// </summary>
		// Token: 0x06003302 RID: 13058 RVA: 0x0004B0E4 File Offset: 0x000492E4
		public virtual int GetTargetLabelCount()
		{
			return vtkPointSetToLabelHierarchy.vtkPointSetToLabelHierarchy_GetTargetLabelCount_10(base.GetCppThis());
		}

		// Token: 0x06003303 RID: 13059
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointSetToLabelHierarchy_GetTextProperty_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/get the text property assigned to the hierarchy.
		/// </summary>
		// Token: 0x06003304 RID: 13060 RVA: 0x0004B104 File Offset: 0x00049304
		public virtual vtkTextProperty GetTextProperty()
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPointSetToLabelHierarchy.vtkPointSetToLabelHierarchy_GetTextProperty_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTextProperty = (vtkTextProperty)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTextProperty.Register(null);
				}
			}
			return vtkTextProperty;
		}

		// Token: 0x06003305 RID: 13061
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointSetToLabelHierarchy_IsA_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003306 RID: 13062 RVA: 0x0004B174 File Offset: 0x00049374
		public override int IsA(string type)
		{
			return vtkPointSetToLabelHierarchy.vtkPointSetToLabelHierarchy_IsA_12(base.GetCppThis(), type);
		}

		// Token: 0x06003307 RID: 13063
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointSetToLabelHierarchy_IsTypeOf_13([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003308 RID: 13064 RVA: 0x0004B194 File Offset: 0x00049394
		public new static int IsTypeOf(string type)
		{
			return vtkPointSetToLabelHierarchy.vtkPointSetToLabelHierarchy_IsTypeOf_13(type);
		}

		// Token: 0x06003309 RID: 13065
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointSetToLabelHierarchy_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600330A RID: 13066 RVA: 0x0004B1B0 File Offset: 0x000493B0
		public new vtkPointSetToLabelHierarchy NewInstance()
		{
			vtkPointSetToLabelHierarchy result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPointSetToLabelHierarchy.vtkPointSetToLabelHierarchy_NewInstance_15(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPointSetToLabelHierarchy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600330B RID: 13067
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointSetToLabelHierarchy_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600330C RID: 13068 RVA: 0x0004B20C File Offset: 0x0004940C
		public new static vtkPointSetToLabelHierarchy SafeDownCast(vtkObjectBase o)
		{
			vtkPointSetToLabelHierarchy vtkPointSetToLabelHierarchy = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPointSetToLabelHierarchy.vtkPointSetToLabelHierarchy_SafeDownCast_16((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPointSetToLabelHierarchy = (vtkPointSetToLabelHierarchy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPointSetToLabelHierarchy.Register(null);
				}
			}
			return vtkPointSetToLabelHierarchy;
		}

		// Token: 0x0600330D RID: 13069
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointSetToLabelHierarchy_SetBoundedSizeArrayName_17(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Set/get the maximum text width (in world coordinates) array name.
		/// </summary>
		// Token: 0x0600330E RID: 13070 RVA: 0x0004B28B File Offset: 0x0004948B
		public virtual void SetBoundedSizeArrayName(string name)
		{
			vtkPointSetToLabelHierarchy.vtkPointSetToLabelHierarchy_SetBoundedSizeArrayName_17(base.GetCppThis(), name);
		}

		// Token: 0x0600330F RID: 13071
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointSetToLabelHierarchy_SetIconIndexArrayName_18(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Set/get the icon index array name.
		/// </summary>
		// Token: 0x06003310 RID: 13072 RVA: 0x0004B29B File Offset: 0x0004949B
		public virtual void SetIconIndexArrayName(string name)
		{
			vtkPointSetToLabelHierarchy.vtkPointSetToLabelHierarchy_SetIconIndexArrayName_18(base.GetCppThis(), name);
		}

		// Token: 0x06003311 RID: 13073
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointSetToLabelHierarchy_SetLabelArrayName_19(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Set/get the label array name.
		/// </summary>
		// Token: 0x06003312 RID: 13074 RVA: 0x0004B2AB File Offset: 0x000494AB
		public virtual void SetLabelArrayName(string name)
		{
			vtkPointSetToLabelHierarchy.vtkPointSetToLabelHierarchy_SetLabelArrayName_19(base.GetCppThis(), name);
		}

		// Token: 0x06003313 RID: 13075
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointSetToLabelHierarchy_SetMaximumDepth_20(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get the maximum tree depth in the output hierarchy.
		/// </summary>
		// Token: 0x06003314 RID: 13076 RVA: 0x0004B2BB File Offset: 0x000494BB
		public virtual void SetMaximumDepth(int _arg)
		{
			vtkPointSetToLabelHierarchy.vtkPointSetToLabelHierarchy_SetMaximumDepth_20(base.GetCppThis(), _arg);
		}

		// Token: 0x06003315 RID: 13077
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointSetToLabelHierarchy_SetOrientationArrayName_21(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Set/get the text orientation array name.
		/// </summary>
		// Token: 0x06003316 RID: 13078 RVA: 0x0004B2CB File Offset: 0x000494CB
		public virtual void SetOrientationArrayName(string name)
		{
			vtkPointSetToLabelHierarchy.vtkPointSetToLabelHierarchy_SetOrientationArrayName_21(base.GetCppThis(), name);
		}

		// Token: 0x06003317 RID: 13079
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointSetToLabelHierarchy_SetPriorityArrayName_22(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Set/get the priority array name.
		/// </summary>
		// Token: 0x06003318 RID: 13080 RVA: 0x0004B2DB File Offset: 0x000494DB
		public virtual void SetPriorityArrayName(string name)
		{
			vtkPointSetToLabelHierarchy.vtkPointSetToLabelHierarchy_SetPriorityArrayName_22(base.GetCppThis(), name);
		}

		// Token: 0x06003319 RID: 13081
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointSetToLabelHierarchy_SetSizeArrayName_23(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Set/get the priority array name.
		/// </summary>
		// Token: 0x0600331A RID: 13082 RVA: 0x0004B2EB File Offset: 0x000494EB
		public virtual void SetSizeArrayName(string name)
		{
			vtkPointSetToLabelHierarchy.vtkPointSetToLabelHierarchy_SetSizeArrayName_23(base.GetCppThis(), name);
		}

		// Token: 0x0600331B RID: 13083
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointSetToLabelHierarchy_SetTargetLabelCount_24(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get the "ideal" number of labels to associate with each node in the output hierarchy.
		/// </summary>
		// Token: 0x0600331C RID: 13084 RVA: 0x0004B2FB File Offset: 0x000494FB
		public virtual void SetTargetLabelCount(int _arg)
		{
			vtkPointSetToLabelHierarchy.vtkPointSetToLabelHierarchy_SetTargetLabelCount_24(base.GetCppThis(), _arg);
		}

		// Token: 0x0600331D RID: 13085
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointSetToLabelHierarchy_SetTextProperty_25(HandleRef pThis, HandleRef tprop);

		/// <summary>
		/// Set/get the text property assigned to the hierarchy.
		/// </summary>
		// Token: 0x0600331E RID: 13086 RVA: 0x0004B30C File Offset: 0x0004950C
		public virtual void SetTextProperty(vtkTextProperty tprop)
		{
			vtkPointSetToLabelHierarchy.vtkPointSetToLabelHierarchy_SetTextProperty_25(base.GetCppThis(), (tprop == null) ? default(HandleRef) : tprop.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000614 RID: 1556
		public new const string MRFullTypeName = "Kitware.VTK.vtkPointSetToLabelHierarchy";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000615 RID: 1557
		public new static readonly string MRClassNameKey = "class vtkPointSetToLabelHierarchy";
	}
}
