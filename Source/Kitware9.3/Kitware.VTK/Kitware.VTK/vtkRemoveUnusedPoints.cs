using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///  vtkRemoveUnusedPoints
	/// </summary>
	/// <remarks>
	///  remove points not used by any cell.
	///
	/// vtkRemoveUnusedPoints is a filter that removes any points that are not used by the
	/// cells. Currently, this filter only supports vtkUnstructuredGrid.
	/// </remarks>
	// Token: 0x02000997 RID: 2455
	public class vtkRemoveUnusedPoints : vtkUnstructuredGridAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060199BD RID: 104893 RVA: 0x00239C4B File Offset: 0x00237E4B
		static vtkRemoveUnusedPoints()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkRemoveUnusedPoints.MRClassNameKey, Type.GetType("Kitware.VTK.vtkRemoveUnusedPoints"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060199BE RID: 104894 RVA: 0x00239C73 File Offset: 0x00237E73
		public vtkRemoveUnusedPoints(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060199BF RID: 104895
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRemoveUnusedPoints_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060199C0 RID: 104896 RVA: 0x00239C84 File Offset: 0x00237E84
		public new static vtkRemoveUnusedPoints New()
		{
			vtkRemoveUnusedPoints result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRemoveUnusedPoints.vtkRemoveUnusedPoints_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRemoveUnusedPoints)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060199C1 RID: 104897 RVA: 0x00239CD8 File Offset: 0x00237ED8
		public vtkRemoveUnusedPoints() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkRemoveUnusedPoints.vtkRemoveUnusedPoints_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060199C2 RID: 104898 RVA: 0x00239D1C File Offset: 0x00237F1C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060199C3 RID: 104899
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRemoveUnusedPoints_GenerateOriginalPointIdsOff_01(HandleRef pThis);

		/// <summary>
		/// Enable adding a `vtkOriginalPointIds` array to the point data
		/// which identifies the original point index. Default is true.
		/// </summary>
		// Token: 0x060199C4 RID: 104900 RVA: 0x00239D27 File Offset: 0x00237F27
		public virtual void GenerateOriginalPointIdsOff()
		{
			vtkRemoveUnusedPoints.vtkRemoveUnusedPoints_GenerateOriginalPointIdsOff_01(base.GetCppThis());
		}

		// Token: 0x060199C5 RID: 104901
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRemoveUnusedPoints_GenerateOriginalPointIdsOn_02(HandleRef pThis);

		/// <summary>
		/// Enable adding a `vtkOriginalPointIds` array to the point data
		/// which identifies the original point index. Default is true.
		/// </summary>
		// Token: 0x060199C6 RID: 104902 RVA: 0x00239D36 File Offset: 0x00237F36
		public virtual void GenerateOriginalPointIdsOn()
		{
			vtkRemoveUnusedPoints.vtkRemoveUnusedPoints_GenerateOriginalPointIdsOn_02(base.GetCppThis());
		}

		// Token: 0x060199C7 RID: 104903
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkRemoveUnusedPoints_GetGenerateOriginalPointIds_03(HandleRef pThis);

		/// <summary>
		/// Enable adding a `vtkOriginalPointIds` array to the point data
		/// which identifies the original point index. Default is true.
		/// </summary>
		// Token: 0x060199C8 RID: 104904 RVA: 0x00239D48 File Offset: 0x00237F48
		public virtual bool GetGenerateOriginalPointIds()
		{
			return vtkRemoveUnusedPoints.vtkRemoveUnusedPoints_GetGenerateOriginalPointIds_03(base.GetCppThis()) != 0;
		}

		// Token: 0x060199C9 RID: 104905
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRemoveUnusedPoints_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060199CA RID: 104906 RVA: 0x00239D70 File Offset: 0x00237F70
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkRemoveUnusedPoints.vtkRemoveUnusedPoints_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x060199CB RID: 104907
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRemoveUnusedPoints_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060199CC RID: 104908 RVA: 0x00239D90 File Offset: 0x00237F90
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkRemoveUnusedPoints.vtkRemoveUnusedPoints_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x060199CD RID: 104909
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRemoveUnusedPoints_GetOriginalPointIdsArrayName_06(HandleRef pThis);

		/// <summary>
		/// Choose the name to use for the original point ids array. Default is `vtkOriginalPointIds`.
		/// This is used only when `GenerateOriginalPointIds` is true.
		/// </summary>
		// Token: 0x060199CE RID: 104910 RVA: 0x00239DAC File Offset: 0x00237FAC
		public virtual string GetOriginalPointIdsArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkRemoveUnusedPoints.vtkRemoveUnusedPoints_GetOriginalPointIdsArrayName_06(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060199CF RID: 104911
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRemoveUnusedPoints_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060199D0 RID: 104912 RVA: 0x00239DE8 File Offset: 0x00237FE8
		public override int IsA(string type)
		{
			return vtkRemoveUnusedPoints.vtkRemoveUnusedPoints_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x060199D1 RID: 104913
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRemoveUnusedPoints_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060199D2 RID: 104914 RVA: 0x00239E08 File Offset: 0x00238008
		public new static int IsTypeOf(string type)
		{
			return vtkRemoveUnusedPoints.vtkRemoveUnusedPoints_IsTypeOf_08(type);
		}

		// Token: 0x060199D3 RID: 104915
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRemoveUnusedPoints_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060199D4 RID: 104916 RVA: 0x00239E24 File Offset: 0x00238024
		public new vtkRemoveUnusedPoints NewInstance()
		{
			vtkRemoveUnusedPoints result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRemoveUnusedPoints.vtkRemoveUnusedPoints_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRemoveUnusedPoints)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060199D5 RID: 104917
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRemoveUnusedPoints_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060199D6 RID: 104918 RVA: 0x00239E80 File Offset: 0x00238080
		public new static vtkRemoveUnusedPoints SafeDownCast(vtkObjectBase o)
		{
			vtkRemoveUnusedPoints vtkRemoveUnusedPoints = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRemoveUnusedPoints.vtkRemoveUnusedPoints_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRemoveUnusedPoints = (vtkRemoveUnusedPoints)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRemoveUnusedPoints.Register(null);
				}
			}
			return vtkRemoveUnusedPoints;
		}

		// Token: 0x060199D7 RID: 104919
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRemoveUnusedPoints_SetGenerateOriginalPointIds_12(HandleRef pThis, byte _arg);

		/// <summary>
		/// Enable adding a `vtkOriginalPointIds` array to the point data
		/// which identifies the original point index. Default is true.
		/// </summary>
		// Token: 0x060199D8 RID: 104920 RVA: 0x00239EFF File Offset: 0x002380FF
		public virtual void SetGenerateOriginalPointIds(bool _arg)
		{
			vtkRemoveUnusedPoints.vtkRemoveUnusedPoints_SetGenerateOriginalPointIds_12(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x060199D9 RID: 104921
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRemoveUnusedPoints_SetOriginalPointIdsArrayName_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Choose the name to use for the original point ids array. Default is `vtkOriginalPointIds`.
		/// This is used only when `GenerateOriginalPointIds` is true.
		/// </summary>
		// Token: 0x060199DA RID: 104922 RVA: 0x00239F17 File Offset: 0x00238117
		public virtual void SetOriginalPointIdsArrayName(string _arg)
		{
			vtkRemoveUnusedPoints.vtkRemoveUnusedPoints_SetOriginalPointIdsArrayName_13(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001BF3 RID: 7155
		public new const string MRFullTypeName = "Kitware.VTK.vtkRemoveUnusedPoints";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001BF4 RID: 7156
		public new static readonly string MRClassNameKey = "class vtkRemoveUnusedPoints";
	}
}
