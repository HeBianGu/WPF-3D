using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkRectilinearGridWriter
	/// </summary>
	/// <remarks>
	///    write vtk rectilinear grid data file
	///
	/// vtkRectilinearGridWriter is a source object that writes ASCII or binary
	/// rectilinear grid data files in vtk format. See text for format details.
	///
	/// @warning
	/// Binary files written on one system may not be readable on other systems.
	/// </remarks>
	// Token: 0x0200070F RID: 1807
	public class vtkRectilinearGridWriter : vtkDataWriter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06012F7A RID: 77690 RVA: 0x001AC287 File Offset: 0x001AA487
		static vtkRectilinearGridWriter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkRectilinearGridWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkRectilinearGridWriter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06012F7B RID: 77691 RVA: 0x001AC2AF File Offset: 0x001AA4AF
		public vtkRectilinearGridWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06012F7C RID: 77692
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRectilinearGridWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012F7D RID: 77693 RVA: 0x001AC2C0 File Offset: 0x001AA4C0
		public new static vtkRectilinearGridWriter New()
		{
			vtkRectilinearGridWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRectilinearGridWriter.vtkRectilinearGridWriter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRectilinearGridWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012F7E RID: 77694 RVA: 0x001AC314 File Offset: 0x001AA514
		public vtkRectilinearGridWriter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkRectilinearGridWriter.vtkRectilinearGridWriter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06012F7F RID: 77695 RVA: 0x001AC358 File Offset: 0x001AA558
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06012F80 RID: 77696
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRectilinearGridWriter_GetInput_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the input to this writer.
		/// </summary>
		// Token: 0x06012F81 RID: 77697 RVA: 0x001AC364 File Offset: 0x001AA564
		public new vtkRectilinearGrid GetInput()
		{
			vtkRectilinearGrid vtkRectilinearGrid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRectilinearGridWriter.vtkRectilinearGridWriter_GetInput_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRectilinearGrid = (vtkRectilinearGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRectilinearGrid.Register(null);
				}
			}
			return vtkRectilinearGrid;
		}

		// Token: 0x06012F82 RID: 77698
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRectilinearGridWriter_GetInput_02(HandleRef pThis, int port, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the input to this writer.
		/// </summary>
		// Token: 0x06012F83 RID: 77699 RVA: 0x001AC3D4 File Offset: 0x001AA5D4
		public new vtkRectilinearGrid GetInput(int port)
		{
			vtkRectilinearGrid vtkRectilinearGrid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRectilinearGridWriter.vtkRectilinearGridWriter_GetInput_02(base.GetCppThis(), port, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRectilinearGrid = (vtkRectilinearGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRectilinearGrid.Register(null);
				}
			}
			return vtkRectilinearGrid;
		}

		// Token: 0x06012F84 RID: 77700
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRectilinearGridWriter_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012F85 RID: 77701 RVA: 0x001AC444 File Offset: 0x001AA644
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkRectilinearGridWriter.vtkRectilinearGridWriter_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x06012F86 RID: 77702
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRectilinearGridWriter_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012F87 RID: 77703 RVA: 0x001AC464 File Offset: 0x001AA664
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkRectilinearGridWriter.vtkRectilinearGridWriter_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x06012F88 RID: 77704
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkRectilinearGridWriter_GetWriteExtent_05(HandleRef pThis);

		/// <summary>
		/// When WriteExtent is on, vtkStructuredPointsWriter writes
		/// data extent in the output file. Otherwise, it writes dimensions.
		/// The only time this option is useful is when the extents do
		/// not start at (0, 0, 0). This is an options to support writing
		/// of older formats while still using a newer VTK.
		/// </summary>
		// Token: 0x06012F89 RID: 77705 RVA: 0x001AC480 File Offset: 0x001AA680
		public virtual bool GetWriteExtent()
		{
			return vtkRectilinearGridWriter.vtkRectilinearGridWriter_GetWriteExtent_05(base.GetCppThis()) != 0;
		}

		// Token: 0x06012F8A RID: 77706
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRectilinearGridWriter_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012F8B RID: 77707 RVA: 0x001AC4A8 File Offset: 0x001AA6A8
		public override int IsA(string type)
		{
			return vtkRectilinearGridWriter.vtkRectilinearGridWriter_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x06012F8C RID: 77708
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRectilinearGridWriter_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012F8D RID: 77709 RVA: 0x001AC4C8 File Offset: 0x001AA6C8
		public new static int IsTypeOf(string type)
		{
			return vtkRectilinearGridWriter.vtkRectilinearGridWriter_IsTypeOf_07(type);
		}

		// Token: 0x06012F8E RID: 77710
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRectilinearGridWriter_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012F8F RID: 77711 RVA: 0x001AC4E4 File Offset: 0x001AA6E4
		public new vtkRectilinearGridWriter NewInstance()
		{
			vtkRectilinearGridWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRectilinearGridWriter.vtkRectilinearGridWriter_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRectilinearGridWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06012F90 RID: 77712
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRectilinearGridWriter_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012F91 RID: 77713 RVA: 0x001AC540 File Offset: 0x001AA740
		public new static vtkRectilinearGridWriter SafeDownCast(vtkObjectBase o)
		{
			vtkRectilinearGridWriter vtkRectilinearGridWriter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRectilinearGridWriter.vtkRectilinearGridWriter_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRectilinearGridWriter = (vtkRectilinearGridWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRectilinearGridWriter.Register(null);
				}
			}
			return vtkRectilinearGridWriter;
		}

		// Token: 0x06012F92 RID: 77714
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRectilinearGridWriter_SetWriteExtent_11(HandleRef pThis, byte _arg);

		/// <summary>
		/// When WriteExtent is on, vtkStructuredPointsWriter writes
		/// data extent in the output file. Otherwise, it writes dimensions.
		/// The only time this option is useful is when the extents do
		/// not start at (0, 0, 0). This is an options to support writing
		/// of older formats while still using a newer VTK.
		/// </summary>
		// Token: 0x06012F93 RID: 77715 RVA: 0x001AC5BF File Offset: 0x001AA7BF
		public virtual void SetWriteExtent(bool _arg)
		{
			vtkRectilinearGridWriter.vtkRectilinearGridWriter_SetWriteExtent_11(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06012F94 RID: 77716
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRectilinearGridWriter_WriteExtentOff_12(HandleRef pThis);

		/// <summary>
		/// When WriteExtent is on, vtkStructuredPointsWriter writes
		/// data extent in the output file. Otherwise, it writes dimensions.
		/// The only time this option is useful is when the extents do
		/// not start at (0, 0, 0). This is an options to support writing
		/// of older formats while still using a newer VTK.
		/// </summary>
		// Token: 0x06012F95 RID: 77717 RVA: 0x001AC5D7 File Offset: 0x001AA7D7
		public virtual void WriteExtentOff()
		{
			vtkRectilinearGridWriter.vtkRectilinearGridWriter_WriteExtentOff_12(base.GetCppThis());
		}

		// Token: 0x06012F96 RID: 77718
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRectilinearGridWriter_WriteExtentOn_13(HandleRef pThis);

		/// <summary>
		/// When WriteExtent is on, vtkStructuredPointsWriter writes
		/// data extent in the output file. Otherwise, it writes dimensions.
		/// The only time this option is useful is when the extents do
		/// not start at (0, 0, 0). This is an options to support writing
		/// of older formats while still using a newer VTK.
		/// </summary>
		// Token: 0x06012F97 RID: 77719 RVA: 0x001AC5E6 File Offset: 0x001AA7E6
		public virtual void WriteExtentOn()
		{
			vtkRectilinearGridWriter.vtkRectilinearGridWriter_WriteExtentOn_13(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040015EA RID: 5610
		public new const string MRFullTypeName = "Kitware.VTK.vtkRectilinearGridWriter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040015EB RID: 5611
		public new static readonly string MRClassNameKey = "class vtkRectilinearGridWriter";
	}
}
