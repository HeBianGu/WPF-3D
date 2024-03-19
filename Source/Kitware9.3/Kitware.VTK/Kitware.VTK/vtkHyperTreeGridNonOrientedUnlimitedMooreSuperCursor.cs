using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkHyperTreeGridNonOrientedUnlimitedMooreSuperCursor
	/// </summary>
	/// <remarks>
	///    Specific Moore super cursor that can subdivied neighborhood
	///
	/// This supercursor behave like the Moore supercursor but relies on the
	/// vtkHyperTreeGridNonOrientedUnlimitedSuperCursor so the neighborhood
	/// can be refined to reach the level of the current cell in any case.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkHyperTreeCursor vtkHyperTree vtkHyperTreeGrid vtkHyperTreeGridNonOrientedMooreSuperCursor
	/// </seealso>
	// Token: 0x02000A62 RID: 2658
	public class vtkHyperTreeGridNonOrientedUnlimitedMooreSuperCursor : vtkHyperTreeGridNonOrientedUnlimitedSuperCursor
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601BCAC RID: 113836 RVA: 0x0026EA82 File Offset: 0x0026CC82
		static vtkHyperTreeGridNonOrientedUnlimitedMooreSuperCursor()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkHyperTreeGridNonOrientedUnlimitedMooreSuperCursor.MRClassNameKey, Type.GetType("Kitware.VTK.vtkHyperTreeGridNonOrientedUnlimitedMooreSuperCursor"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601BCAD RID: 113837 RVA: 0x0026EAAA File Offset: 0x0026CCAA
		public vtkHyperTreeGridNonOrientedUnlimitedMooreSuperCursor(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601BCAE RID: 113838
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHyperTreeGridNonOrientedUnlimitedMooreSuperCursor_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BCAF RID: 113839 RVA: 0x0026EAB8 File Offset: 0x0026CCB8
		public new static vtkHyperTreeGridNonOrientedUnlimitedMooreSuperCursor New()
		{
			vtkHyperTreeGridNonOrientedUnlimitedMooreSuperCursor result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHyperTreeGridNonOrientedUnlimitedMooreSuperCursor.vtkHyperTreeGridNonOrientedUnlimitedMooreSuperCursor_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHyperTreeGridNonOrientedUnlimitedMooreSuperCursor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BCB0 RID: 113840 RVA: 0x0026EB0C File Offset: 0x0026CD0C
		public vtkHyperTreeGridNonOrientedUnlimitedMooreSuperCursor() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkHyperTreeGridNonOrientedUnlimitedMooreSuperCursor.vtkHyperTreeGridNonOrientedUnlimitedMooreSuperCursor_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601BCB1 RID: 113841 RVA: 0x0026EB50 File Offset: 0x0026CD50
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601BCB2 RID: 113842
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkHyperTreeGridNonOrientedUnlimitedMooreSuperCursor_GetCornerCursors_01(HandleRef pThis, uint arg0, uint arg1, HandleRef arg2);

		/// <summary>
		/// Return the list of cursors pointing to the leaves touching a
		/// given corner of the cell.
		/// Return whether the considered cell is the owner of said corner.
		/// JB Utilise aujourd'hui dans les filtres vtkHyperTreeGridContour et vtkHyperTreeGridPlaneCutter.
		/// </summary>
		// Token: 0x0601BCB3 RID: 113843 RVA: 0x0026EB5C File Offset: 0x0026CD5C
		public bool GetCornerCursors(uint arg0, uint arg1, vtkIdList arg2)
		{
			return vtkHyperTreeGridNonOrientedUnlimitedMooreSuperCursor.vtkHyperTreeGridNonOrientedUnlimitedMooreSuperCursor_GetCornerCursors_01(base.GetCppThis(), arg0, arg1, (arg2 == null) ? default(HandleRef) : arg2.GetCppThis()) != 0;
		}

		// Token: 0x0601BCB4 RID: 113844
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHyperTreeGridNonOrientedUnlimitedMooreSuperCursor_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BCB5 RID: 113845 RVA: 0x0026EB9C File Offset: 0x0026CD9C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkHyperTreeGridNonOrientedUnlimitedMooreSuperCursor.vtkHyperTreeGridNonOrientedUnlimitedMooreSuperCursor_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0601BCB6 RID: 113846
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHyperTreeGridNonOrientedUnlimitedMooreSuperCursor_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BCB7 RID: 113847 RVA: 0x0026EBBC File Offset: 0x0026CDBC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkHyperTreeGridNonOrientedUnlimitedMooreSuperCursor.vtkHyperTreeGridNonOrientedUnlimitedMooreSuperCursor_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0601BCB8 RID: 113848
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHyperTreeGridNonOrientedUnlimitedMooreSuperCursor_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BCB9 RID: 113849 RVA: 0x0026EBD8 File Offset: 0x0026CDD8
		public override int IsA(string type)
		{
			return vtkHyperTreeGridNonOrientedUnlimitedMooreSuperCursor.vtkHyperTreeGridNonOrientedUnlimitedMooreSuperCursor_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x0601BCBA RID: 113850
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHyperTreeGridNonOrientedUnlimitedMooreSuperCursor_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BCBB RID: 113851 RVA: 0x0026EBF8 File Offset: 0x0026CDF8
		public new static int IsTypeOf(string type)
		{
			return vtkHyperTreeGridNonOrientedUnlimitedMooreSuperCursor.vtkHyperTreeGridNonOrientedUnlimitedMooreSuperCursor_IsTypeOf_05(type);
		}

		// Token: 0x0601BCBC RID: 113852
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHyperTreeGridNonOrientedUnlimitedMooreSuperCursor_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BCBD RID: 113853 RVA: 0x0026EC14 File Offset: 0x0026CE14
		public new vtkHyperTreeGridNonOrientedUnlimitedMooreSuperCursor NewInstance()
		{
			vtkHyperTreeGridNonOrientedUnlimitedMooreSuperCursor result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHyperTreeGridNonOrientedUnlimitedMooreSuperCursor.vtkHyperTreeGridNonOrientedUnlimitedMooreSuperCursor_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHyperTreeGridNonOrientedUnlimitedMooreSuperCursor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601BCBE RID: 113854
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHyperTreeGridNonOrientedUnlimitedMooreSuperCursor_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BCBF RID: 113855 RVA: 0x0026EC70 File Offset: 0x0026CE70
		public new static vtkHyperTreeGridNonOrientedUnlimitedMooreSuperCursor SafeDownCast(vtkObjectBase o)
		{
			vtkHyperTreeGridNonOrientedUnlimitedMooreSuperCursor vtkHyperTreeGridNonOrientedUnlimitedMooreSuperCursor = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHyperTreeGridNonOrientedUnlimitedMooreSuperCursor.vtkHyperTreeGridNonOrientedUnlimitedMooreSuperCursor_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHyperTreeGridNonOrientedUnlimitedMooreSuperCursor = (vtkHyperTreeGridNonOrientedUnlimitedMooreSuperCursor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHyperTreeGridNonOrientedUnlimitedMooreSuperCursor.Register(null);
				}
			}
			return vtkHyperTreeGridNonOrientedUnlimitedMooreSuperCursor;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001DB8 RID: 7608
		public new const string MRFullTypeName = "Kitware.VTK.vtkHyperTreeGridNonOrientedUnlimitedMooreSuperCursor";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001DB9 RID: 7609
		public new static readonly string MRClassNameKey = "class vtkHyperTreeGridNonOrientedUnlimitedMooreSuperCursor";
	}
}
