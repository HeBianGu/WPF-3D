using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkDeRhamCell
	/// </summary>
	/// <remarks>
	///    Base class for cells that form 2-d or 3-d DeRham complexes.
	///
	/// This class exists so that cell-attributes specific to DeRham sequences
	/// can register responders and calculators.
	/// Only 2-d and 3-d cell-shapes are allowed to subclass vtkDeRhamCell
	/// since H(Curl) and H(Div) function spaces require cells of parametric
	/// dimension 2 or greater.
	///
	/// This class inherits the API of vtkDGCell.
	/// </remarks>
	// Token: 0x020004E0 RID: 1248
	public abstract class vtkDeRhamCell : vtkDGCell
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600E1EC RID: 57836 RVA: 0x0013A09F File Offset: 0x0013829F
		static vtkDeRhamCell()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDeRhamCell.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDeRhamCell"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600E1ED RID: 57837 RVA: 0x0013A0C7 File Offset: 0x001382C7
		public vtkDeRhamCell(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600E1EE RID: 57838 RVA: 0x0013A0D5 File Offset: 0x001382D5
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600E1EF RID: 57839
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDeRhamCell_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E1F0 RID: 57840 RVA: 0x0013A0E0 File Offset: 0x001382E0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDeRhamCell.vtkDeRhamCell_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0600E1F1 RID: 57841
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDeRhamCell_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E1F2 RID: 57842 RVA: 0x0013A100 File Offset: 0x00138300
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDeRhamCell.vtkDeRhamCell_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0600E1F3 RID: 57843
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDeRhamCell_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E1F4 RID: 57844 RVA: 0x0013A11C File Offset: 0x0013831C
		public override int IsA(string type)
		{
			return vtkDeRhamCell.vtkDeRhamCell_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x0600E1F5 RID: 57845
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDeRhamCell_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E1F6 RID: 57846 RVA: 0x0013A13C File Offset: 0x0013833C
		public new static int IsTypeOf(string type)
		{
			return vtkDeRhamCell.vtkDeRhamCell_IsTypeOf_04(type);
		}

		// Token: 0x0600E1F7 RID: 57847
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDeRhamCell_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E1F8 RID: 57848 RVA: 0x0013A158 File Offset: 0x00138358
		public new vtkDeRhamCell NewInstance()
		{
			vtkDeRhamCell result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDeRhamCell.vtkDeRhamCell_NewInstance_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDeRhamCell)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600E1F9 RID: 57849
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDeRhamCell_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E1FA RID: 57850 RVA: 0x0013A1B4 File Offset: 0x001383B4
		public new static vtkDeRhamCell SafeDownCast(vtkObjectBase o)
		{
			vtkDeRhamCell vtkDeRhamCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDeRhamCell.vtkDeRhamCell_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDeRhamCell = (vtkDeRhamCell)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDeRhamCell.Register(null);
				}
			}
			return vtkDeRhamCell;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040010A3 RID: 4259
		public new const string MRFullTypeName = "Kitware.VTK.vtkDeRhamCell";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040010A4 RID: 4260
		public new static readonly string MRClassNameKey = "class vtkDeRhamCell";
	}
}
