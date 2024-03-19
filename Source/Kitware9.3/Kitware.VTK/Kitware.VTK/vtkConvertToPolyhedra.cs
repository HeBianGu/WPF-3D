using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkConvertToPolyhedra
	/// </summary>
	/// <remarks>
	///    convert 3D linear cells to vtkPolyhedra
	///
	/// vtkConvertToPolyhedra is a filter that takes a vtkUnstructuredGrid as
	/// input and produces a vtkUnstructuredGrid on output, converting 3D linear
	/// cells such as tetrahedra, hexahedra, wedges, and pyramids into
	/// vtkPolyhedron.
	///
	/// @warning
	/// Certain cells are skipped and not converted, this includes cells of dimension
	/// two or less (e.g., triangles, quads, lines, verts, and so on); and higher
	/// order cells that cannot easily be converted to vtkPolyhedra. (TODO: tessellate
	/// high-order 3D cell faces and then use these to form the polyhedra.)
	///
	/// @warning
	/// This filter is typically used for testing. In general, processing linear cells
	/// is preferable to processing polyhedra due to differences in speed of processing,
	/// and memory requirements.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkUnstructuredGrid vtkPolyhedron
	/// </seealso>
	// Token: 0x02000954 RID: 2388
	public class vtkConvertToPolyhedra : vtkUnstructuredGridAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06018C6B RID: 101483 RVA: 0x00229547 File Offset: 0x00227747
		static vtkConvertToPolyhedra()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkConvertToPolyhedra.MRClassNameKey, Type.GetType("Kitware.VTK.vtkConvertToPolyhedra"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06018C6C RID: 101484 RVA: 0x0022956F File Offset: 0x0022776F
		public vtkConvertToPolyhedra(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06018C6D RID: 101485
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkConvertToPolyhedra_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and
		/// printing the state of the object.
		/// </summary>
		// Token: 0x06018C6E RID: 101486 RVA: 0x00229580 File Offset: 0x00227780
		public new static vtkConvertToPolyhedra New()
		{
			vtkConvertToPolyhedra result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkConvertToPolyhedra.vtkConvertToPolyhedra_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkConvertToPolyhedra)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and
		/// printing the state of the object.
		/// </summary>
		// Token: 0x06018C6F RID: 101487 RVA: 0x002295D4 File Offset: 0x002277D4
		public vtkConvertToPolyhedra() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkConvertToPolyhedra.vtkConvertToPolyhedra_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06018C70 RID: 101488 RVA: 0x00229618 File Offset: 0x00227818
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06018C71 RID: 101489
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkConvertToPolyhedra_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and
		/// printing the state of the object.
		/// </summary>
		// Token: 0x06018C72 RID: 101490 RVA: 0x00229624 File Offset: 0x00227824
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkConvertToPolyhedra.vtkConvertToPolyhedra_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06018C73 RID: 101491
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkConvertToPolyhedra_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and
		/// printing the state of the object.
		/// </summary>
		// Token: 0x06018C74 RID: 101492 RVA: 0x00229644 File Offset: 0x00227844
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkConvertToPolyhedra.vtkConvertToPolyhedra_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06018C75 RID: 101493
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkConvertToPolyhedra_GetOutputAllCells_03(HandleRef pThis);

		/// <summary>
		/// Indicate whether to include non-polyhedral cells in the filter output.
		/// Non-polyhedral cells are cells which cannot be converted to polyhedra,
		/// for example cells of dimension &lt; 3, and higher-order cells.
		/// If enabled, the output will contain a mix of polyhedra and non-polyhedra
		/// cells. If disabled, only polyhedra cells will be output. By default, this
		/// is disabled.
		/// </summary>
		// Token: 0x06018C76 RID: 101494 RVA: 0x00229660 File Offset: 0x00227860
		public virtual bool GetOutputAllCells()
		{
			return vtkConvertToPolyhedra.vtkConvertToPolyhedra_GetOutputAllCells_03(base.GetCppThis()) != 0;
		}

		// Token: 0x06018C77 RID: 101495
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkConvertToPolyhedra_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and
		/// printing the state of the object.
		/// </summary>
		// Token: 0x06018C78 RID: 101496 RVA: 0x00229688 File Offset: 0x00227888
		public override int IsA(string type)
		{
			return vtkConvertToPolyhedra.vtkConvertToPolyhedra_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x06018C79 RID: 101497
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkConvertToPolyhedra_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and
		/// printing the state of the object.
		/// </summary>
		// Token: 0x06018C7A RID: 101498 RVA: 0x002296A8 File Offset: 0x002278A8
		public new static int IsTypeOf(string type)
		{
			return vtkConvertToPolyhedra.vtkConvertToPolyhedra_IsTypeOf_05(type);
		}

		// Token: 0x06018C7B RID: 101499
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkConvertToPolyhedra_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and
		/// printing the state of the object.
		/// </summary>
		// Token: 0x06018C7C RID: 101500 RVA: 0x002296C4 File Offset: 0x002278C4
		public new vtkConvertToPolyhedra NewInstance()
		{
			vtkConvertToPolyhedra result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkConvertToPolyhedra.vtkConvertToPolyhedra_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkConvertToPolyhedra)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06018C7D RID: 101501
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConvertToPolyhedra_OutputAllCellsOff_08(HandleRef pThis);

		/// <summary>
		/// Indicate whether to include non-polyhedral cells in the filter output.
		/// Non-polyhedral cells are cells which cannot be converted to polyhedra,
		/// for example cells of dimension &lt; 3, and higher-order cells.
		/// If enabled, the output will contain a mix of polyhedra and non-polyhedra
		/// cells. If disabled, only polyhedra cells will be output. By default, this
		/// is disabled.
		/// </summary>
		// Token: 0x06018C7E RID: 101502 RVA: 0x0022971E File Offset: 0x0022791E
		public virtual void OutputAllCellsOff()
		{
			vtkConvertToPolyhedra.vtkConvertToPolyhedra_OutputAllCellsOff_08(base.GetCppThis());
		}

		// Token: 0x06018C7F RID: 101503
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConvertToPolyhedra_OutputAllCellsOn_09(HandleRef pThis);

		/// <summary>
		/// Indicate whether to include non-polyhedral cells in the filter output.
		/// Non-polyhedral cells are cells which cannot be converted to polyhedra,
		/// for example cells of dimension &lt; 3, and higher-order cells.
		/// If enabled, the output will contain a mix of polyhedra and non-polyhedra
		/// cells. If disabled, only polyhedra cells will be output. By default, this
		/// is disabled.
		/// </summary>
		// Token: 0x06018C80 RID: 101504 RVA: 0x0022972D File Offset: 0x0022792D
		public virtual void OutputAllCellsOn()
		{
			vtkConvertToPolyhedra.vtkConvertToPolyhedra_OutputAllCellsOn_09(base.GetCppThis());
		}

		// Token: 0x06018C81 RID: 101505
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkConvertToPolyhedra_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and
		/// printing the state of the object.
		/// </summary>
		// Token: 0x06018C82 RID: 101506 RVA: 0x0022973C File Offset: 0x0022793C
		public new static vtkConvertToPolyhedra SafeDownCast(vtkObjectBase o)
		{
			vtkConvertToPolyhedra vtkConvertToPolyhedra = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkConvertToPolyhedra.vtkConvertToPolyhedra_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkConvertToPolyhedra = (vtkConvertToPolyhedra)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkConvertToPolyhedra.Register(null);
				}
			}
			return vtkConvertToPolyhedra;
		}

		// Token: 0x06018C83 RID: 101507
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConvertToPolyhedra_SetOutputAllCells_11(HandleRef pThis, byte _arg);

		/// <summary>
		/// Indicate whether to include non-polyhedral cells in the filter output.
		/// Non-polyhedral cells are cells which cannot be converted to polyhedra,
		/// for example cells of dimension &lt; 3, and higher-order cells.
		/// If enabled, the output will contain a mix of polyhedra and non-polyhedra
		/// cells. If disabled, only polyhedra cells will be output. By default, this
		/// is disabled.
		/// </summary>
		// Token: 0x06018C84 RID: 101508 RVA: 0x002297BB File Offset: 0x002279BB
		public virtual void SetOutputAllCells(bool _arg)
		{
			vtkConvertToPolyhedra.vtkConvertToPolyhedra_SetOutputAllCells_11(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B61 RID: 7009
		public new const string MRFullTypeName = "Kitware.VTK.vtkConvertToPolyhedra";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B62 RID: 7010
		public new static readonly string MRClassNameKey = "class vtkConvertToPolyhedra";
	}
}
