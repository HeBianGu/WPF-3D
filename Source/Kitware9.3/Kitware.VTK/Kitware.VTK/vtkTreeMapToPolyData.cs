using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkTreeMapToPolyData
	/// </summary>
	/// <remarks>
	///    converts a tree to a polygonal data representing a tree map
	///
	///
	/// This algorithm requires that the vtkTreeMapLayout filter has already applied to the
	/// data in order to create the quadruple array (min x, max x, min y, max y) of
	/// bounds for each vertex of the tree.
	/// </remarks>
	// Token: 0x020002A3 RID: 675
	public class vtkTreeMapToPolyData : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060079B2 RID: 31154 RVA: 0x000AF663 File Offset: 0x000AD863
		static vtkTreeMapToPolyData()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTreeMapToPolyData.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTreeMapToPolyData"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060079B3 RID: 31155 RVA: 0x000AF68B File Offset: 0x000AD88B
		public vtkTreeMapToPolyData(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060079B4 RID: 31156
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTreeMapToPolyData_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060079B5 RID: 31157 RVA: 0x000AF69C File Offset: 0x000AD89C
		public new static vtkTreeMapToPolyData New()
		{
			vtkTreeMapToPolyData result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTreeMapToPolyData.vtkTreeMapToPolyData_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTreeMapToPolyData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060079B6 RID: 31158 RVA: 0x000AF6F0 File Offset: 0x000AD8F0
		public vtkTreeMapToPolyData() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkTreeMapToPolyData.vtkTreeMapToPolyData_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060079B7 RID: 31159 RVA: 0x000AF734 File Offset: 0x000AD934
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060079B8 RID: 31160
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTreeMapToPolyData_FillInputPortInformation_01(HandleRef pThis, int port, HandleRef info);

		/// <summary>
		/// The spacing along the z-axis between tree map levels.
		/// </summary>
		// Token: 0x060079B9 RID: 31161 RVA: 0x000AF740 File Offset: 0x000AD940
		public virtual int FillInputPortInformation(int port, vtkInformation info)
		{
			return vtkTreeMapToPolyData.vtkTreeMapToPolyData_FillInputPortInformation_01(base.GetCppThis(), port, (info == null) ? default(HandleRef) : info.GetCppThis());
		}

		// Token: 0x060079BA RID: 31162
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkTreeMapToPolyData_GetAddNormals_02(HandleRef pThis);

		/// <summary>
		/// The spacing along the z-axis between tree map levels.
		/// </summary>
		// Token: 0x060079BB RID: 31163 RVA: 0x000AF778 File Offset: 0x000AD978
		public virtual bool GetAddNormals()
		{
			return vtkTreeMapToPolyData.vtkTreeMapToPolyData_GetAddNormals_02(base.GetCppThis()) != 0;
		}

		// Token: 0x060079BC RID: 31164
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkTreeMapToPolyData_GetLevelDeltaZ_03(HandleRef pThis);

		/// <summary>
		/// The spacing along the z-axis between tree map levels.
		/// </summary>
		// Token: 0x060079BD RID: 31165 RVA: 0x000AF7A0 File Offset: 0x000AD9A0
		public virtual double GetLevelDeltaZ()
		{
			return vtkTreeMapToPolyData.vtkTreeMapToPolyData_GetLevelDeltaZ_03(base.GetCppThis());
		}

		// Token: 0x060079BE RID: 31166
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTreeMapToPolyData_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060079BF RID: 31167 RVA: 0x000AF7C0 File Offset: 0x000AD9C0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTreeMapToPolyData.vtkTreeMapToPolyData_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x060079C0 RID: 31168
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTreeMapToPolyData_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060079C1 RID: 31169 RVA: 0x000AF7E0 File Offset: 0x000AD9E0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTreeMapToPolyData.vtkTreeMapToPolyData_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x060079C2 RID: 31170
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTreeMapToPolyData_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060079C3 RID: 31171 RVA: 0x000AF7FC File Offset: 0x000AD9FC
		public override int IsA(string type)
		{
			return vtkTreeMapToPolyData.vtkTreeMapToPolyData_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x060079C4 RID: 31172
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTreeMapToPolyData_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060079C5 RID: 31173 RVA: 0x000AF81C File Offset: 0x000ADA1C
		public new static int IsTypeOf(string type)
		{
			return vtkTreeMapToPolyData.vtkTreeMapToPolyData_IsTypeOf_07(type);
		}

		// Token: 0x060079C6 RID: 31174
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTreeMapToPolyData_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060079C7 RID: 31175 RVA: 0x000AF838 File Offset: 0x000ADA38
		public new vtkTreeMapToPolyData NewInstance()
		{
			vtkTreeMapToPolyData result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTreeMapToPolyData.vtkTreeMapToPolyData_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTreeMapToPolyData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060079C8 RID: 31176
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTreeMapToPolyData_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060079C9 RID: 31177 RVA: 0x000AF894 File Offset: 0x000ADA94
		public new static vtkTreeMapToPolyData SafeDownCast(vtkObjectBase o)
		{
			vtkTreeMapToPolyData vtkTreeMapToPolyData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTreeMapToPolyData.vtkTreeMapToPolyData_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTreeMapToPolyData = (vtkTreeMapToPolyData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTreeMapToPolyData.Register(null);
				}
			}
			return vtkTreeMapToPolyData;
		}

		// Token: 0x060079CA RID: 31178
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTreeMapToPolyData_SetAddNormals_11(HandleRef pThis, byte _arg);

		/// <summary>
		/// The spacing along the z-axis between tree map levels.
		/// </summary>
		// Token: 0x060079CB RID: 31179 RVA: 0x000AF913 File Offset: 0x000ADB13
		public virtual void SetAddNormals(bool _arg)
		{
			vtkTreeMapToPolyData.vtkTreeMapToPolyData_SetAddNormals_11(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x060079CC RID: 31180
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTreeMapToPolyData_SetLevelArrayName_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// The field containing the level of each tree node.
		/// This can be added using vtkTreeLevelsFilter before this filter.
		/// If this is not present, the filter simply calls tree-&gt;GetLevel(v) for
		/// each vertex, which will produce the same result, but
		/// may not be as efficient.
		/// </summary>
		// Token: 0x060079CD RID: 31181 RVA: 0x000AF92B File Offset: 0x000ADB2B
		public virtual void SetLevelArrayName(string name)
		{
			vtkTreeMapToPolyData.vtkTreeMapToPolyData_SetLevelArrayName_12(base.GetCppThis(), name);
		}

		// Token: 0x060079CE RID: 31182
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTreeMapToPolyData_SetLevelDeltaZ_13(HandleRef pThis, double _arg);

		/// <summary>
		/// The spacing along the z-axis between tree map levels.
		/// </summary>
		// Token: 0x060079CF RID: 31183 RVA: 0x000AF93B File Offset: 0x000ADB3B
		public virtual void SetLevelDeltaZ(double _arg)
		{
			vtkTreeMapToPolyData.vtkTreeMapToPolyData_SetLevelDeltaZ_13(base.GetCppThis(), _arg);
		}

		// Token: 0x060079D0 RID: 31184
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTreeMapToPolyData_SetRectanglesArrayName_14(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// The field containing quadruples of the form (min x, max x, min y, max y)
		/// representing the bounds of the rectangles for each vertex.
		/// This array may be added to the tree using vtkTreeMapLayout.
		/// </summary>
		// Token: 0x060079D1 RID: 31185 RVA: 0x000AF94B File Offset: 0x000ADB4B
		public virtual void SetRectanglesArrayName(string name)
		{
			vtkTreeMapToPolyData.vtkTreeMapToPolyData_SetRectanglesArrayName_14(base.GetCppThis(), name);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000A56 RID: 2646
		public new const string MRFullTypeName = "Kitware.VTK.vtkTreeMapToPolyData";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000A57 RID: 2647
		public new static readonly string MRClassNameKey = "class vtkTreeMapToPolyData";
	}
}
