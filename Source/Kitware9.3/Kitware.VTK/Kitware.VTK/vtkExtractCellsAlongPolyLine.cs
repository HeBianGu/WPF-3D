using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkExtractCellsAlongPolyLine
	/// </summary>
	/// <remarks>
	///    Extracts input cells that are intersected by a list of input lines or poly lines
	///
	/// This filter extracts input cells that are intersected by a list of input lines or poly lines.
	/// The lines / poly lines input is set on input port 1, as a source connection, while the input data
	/// set on which cells are extracted is to be set on input port 0. The produced output is a
	/// `vtkUnstructuredGrid`. Input lines can be either set inside a `vtkPolyData` or a
	/// `vtkUnstructuredGrid`. If the input type has an explicit geometry, i.e. the input is not a
	/// `vtkPointSet`, then the user can set the output
	/// points precision using `OutputPointsPrecisions`. Otherwise, the point precision is set to be the
	/// same as the input.
	///
	/// This filter uses multi-threading if available.
	/// </remarks>
	// Token: 0x02000964 RID: 2404
	public class vtkExtractCellsAlongPolyLine : vtkUnstructuredGridAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06019016 RID: 102422 RVA: 0x0022E123 File Offset: 0x0022C323
		static vtkExtractCellsAlongPolyLine()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkExtractCellsAlongPolyLine.MRClassNameKey, Type.GetType("Kitware.VTK.vtkExtractCellsAlongPolyLine"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06019017 RID: 102423 RVA: 0x0022E14B File Offset: 0x0022C34B
		public vtkExtractCellsAlongPolyLine(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06019018 RID: 102424
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractCellsAlongPolyLine_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019019 RID: 102425 RVA: 0x0022E15C File Offset: 0x0022C35C
		public new static vtkExtractCellsAlongPolyLine New()
		{
			vtkExtractCellsAlongPolyLine result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractCellsAlongPolyLine.vtkExtractCellsAlongPolyLine_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractCellsAlongPolyLine)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601901A RID: 102426 RVA: 0x0022E1B0 File Offset: 0x0022C3B0
		public vtkExtractCellsAlongPolyLine() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkExtractCellsAlongPolyLine.vtkExtractCellsAlongPolyLine_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601901B RID: 102427 RVA: 0x0022E1F4 File Offset: 0x0022C3F4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601901C RID: 102428
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExtractCellsAlongPolyLine_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601901D RID: 102429 RVA: 0x0022E200 File Offset: 0x0022C400
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkExtractCellsAlongPolyLine.vtkExtractCellsAlongPolyLine_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0601901E RID: 102430
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExtractCellsAlongPolyLine_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601901F RID: 102431 RVA: 0x0022E220 File Offset: 0x0022C420
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkExtractCellsAlongPolyLine.vtkExtractCellsAlongPolyLine_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06019020 RID: 102432
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractCellsAlongPolyLine_GetOutputPointsPrecision_03(HandleRef pThis);

		/// <summary>
		/// Set/get the desired precision for the output types. See the documentation
		/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
		/// the available precision settings. OutputPointsPrecision is DEFAULT_PRECISION
		/// by default. However, if the input is polymorphic to `vtkPointSet`, then
		/// the points precision of the input's points is used instead.
		/// </summary>
		// Token: 0x06019021 RID: 102433 RVA: 0x0022E23C File Offset: 0x0022C43C
		public virtual int GetOutputPointsPrecision()
		{
			return vtkExtractCellsAlongPolyLine.vtkExtractCellsAlongPolyLine_GetOutputPointsPrecision_03(base.GetCppThis());
		}

		// Token: 0x06019022 RID: 102434
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractCellsAlongPolyLine_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019023 RID: 102435 RVA: 0x0022E25C File Offset: 0x0022C45C
		public override int IsA(string type)
		{
			return vtkExtractCellsAlongPolyLine.vtkExtractCellsAlongPolyLine_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x06019024 RID: 102436
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractCellsAlongPolyLine_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019025 RID: 102437 RVA: 0x0022E27C File Offset: 0x0022C47C
		public new static int IsTypeOf(string type)
		{
			return vtkExtractCellsAlongPolyLine.vtkExtractCellsAlongPolyLine_IsTypeOf_05(type);
		}

		// Token: 0x06019026 RID: 102438
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractCellsAlongPolyLine_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019027 RID: 102439 RVA: 0x0022E298 File Offset: 0x0022C498
		public new vtkExtractCellsAlongPolyLine NewInstance()
		{
			vtkExtractCellsAlongPolyLine result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractCellsAlongPolyLine.vtkExtractCellsAlongPolyLine_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractCellsAlongPolyLine)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06019028 RID: 102440
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractCellsAlongPolyLine_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019029 RID: 102441 RVA: 0x0022E2F4 File Offset: 0x0022C4F4
		public new static vtkExtractCellsAlongPolyLine SafeDownCast(vtkObjectBase o)
		{
			vtkExtractCellsAlongPolyLine vtkExtractCellsAlongPolyLine = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractCellsAlongPolyLine.vtkExtractCellsAlongPolyLine_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExtractCellsAlongPolyLine = (vtkExtractCellsAlongPolyLine)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExtractCellsAlongPolyLine.Register(null);
				}
			}
			return vtkExtractCellsAlongPolyLine;
		}

		// Token: 0x0601902A RID: 102442
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractCellsAlongPolyLine_SetOutputPointsPrecision_09(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get the desired precision for the output types. See the documentation
		/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
		/// the available precision settings. OutputPointsPrecision is DEFAULT_PRECISION
		/// by default. However, if the input is polymorphic to `vtkPointSet`, then
		/// the points precision of the input's points is used instead.
		/// </summary>
		// Token: 0x0601902B RID: 102443 RVA: 0x0022E373 File Offset: 0x0022C573
		public virtual void SetOutputPointsPrecision(int _arg)
		{
			vtkExtractCellsAlongPolyLine.vtkExtractCellsAlongPolyLine_SetOutputPointsPrecision_09(base.GetCppThis(), _arg);
		}

		// Token: 0x0601902C RID: 102444
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractCellsAlongPolyLine_SetSourceConnection_10(HandleRef pThis, HandleRef input);

		/// <summary>
		/// Set the source for creating the lines to probe from. Only cells of type VTK_LINE or
		/// VTK_POLY_LINE will be processed.
		/// </summary>
		// Token: 0x0601902D RID: 102445 RVA: 0x0022E384 File Offset: 0x0022C584
		public virtual void SetSourceConnection(vtkAlgorithmOutput input)
		{
			vtkExtractCellsAlongPolyLine.vtkExtractCellsAlongPolyLine_SetSourceConnection_10(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B81 RID: 7041
		public new const string MRFullTypeName = "Kitware.VTK.vtkExtractCellsAlongPolyLine";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B82 RID: 7042
		public new static readonly string MRClassNameKey = "class vtkExtractCellsAlongPolyLine";
	}
}
