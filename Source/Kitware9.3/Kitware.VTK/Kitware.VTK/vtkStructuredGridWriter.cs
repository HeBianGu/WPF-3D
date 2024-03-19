using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkStructuredGridWriter
	/// </summary>
	/// <remarks>
	///    write vtk structured grid data file
	///
	/// vtkStructuredGridWriter is a source object that writes ASCII or binary
	/// structured grid data files in vtk format. See text for format details.
	///
	/// @warning
	/// Binary files written on one system may not be readable on other systems.
	/// </remarks>
	// Token: 0x02000713 RID: 1811
	public class vtkStructuredGridWriter : vtkDataWriter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06012FE0 RID: 77792 RVA: 0x001ACE7F File Offset: 0x001AB07F
		static vtkStructuredGridWriter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkStructuredGridWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkStructuredGridWriter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06012FE1 RID: 77793 RVA: 0x001ACEA7 File Offset: 0x001AB0A7
		public vtkStructuredGridWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06012FE2 RID: 77794
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStructuredGridWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012FE3 RID: 77795 RVA: 0x001ACEB8 File Offset: 0x001AB0B8
		public new static vtkStructuredGridWriter New()
		{
			vtkStructuredGridWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStructuredGridWriter.vtkStructuredGridWriter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStructuredGridWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012FE4 RID: 77796 RVA: 0x001ACF0C File Offset: 0x001AB10C
		public vtkStructuredGridWriter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkStructuredGridWriter.vtkStructuredGridWriter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06012FE5 RID: 77797 RVA: 0x001ACF50 File Offset: 0x001AB150
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06012FE6 RID: 77798
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStructuredGridWriter_GetInput_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the input to this writer.
		/// </summary>
		// Token: 0x06012FE7 RID: 77799 RVA: 0x001ACF5C File Offset: 0x001AB15C
		public new vtkStructuredGrid GetInput()
		{
			vtkStructuredGrid vtkStructuredGrid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStructuredGridWriter.vtkStructuredGridWriter_GetInput_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStructuredGrid = (vtkStructuredGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStructuredGrid.Register(null);
				}
			}
			return vtkStructuredGrid;
		}

		// Token: 0x06012FE8 RID: 77800
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStructuredGridWriter_GetInput_02(HandleRef pThis, int port, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the input to this writer.
		/// </summary>
		// Token: 0x06012FE9 RID: 77801 RVA: 0x001ACFCC File Offset: 0x001AB1CC
		public new vtkStructuredGrid GetInput(int port)
		{
			vtkStructuredGrid vtkStructuredGrid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStructuredGridWriter.vtkStructuredGridWriter_GetInput_02(base.GetCppThis(), port, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStructuredGrid = (vtkStructuredGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStructuredGrid.Register(null);
				}
			}
			return vtkStructuredGrid;
		}

		// Token: 0x06012FEA RID: 77802
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkStructuredGridWriter_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012FEB RID: 77803 RVA: 0x001AD03C File Offset: 0x001AB23C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkStructuredGridWriter.vtkStructuredGridWriter_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x06012FEC RID: 77804
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkStructuredGridWriter_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012FED RID: 77805 RVA: 0x001AD05C File Offset: 0x001AB25C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkStructuredGridWriter.vtkStructuredGridWriter_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x06012FEE RID: 77806
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkStructuredGridWriter_GetWriteExtent_05(HandleRef pThis);

		/// <summary>
		/// When WriteExtent is on, vtkStructuredPointsWriter writes
		/// data extent in the output file. Otherwise, it writes dimensions.
		/// The only time this option is useful is when the extents do
		/// not start at (0, 0, 0). This is an options to support writing
		/// of older formats while still using a newer VTK.
		/// </summary>
		// Token: 0x06012FEF RID: 77807 RVA: 0x001AD078 File Offset: 0x001AB278
		public virtual bool GetWriteExtent()
		{
			return vtkStructuredGridWriter.vtkStructuredGridWriter_GetWriteExtent_05(base.GetCppThis()) != 0;
		}

		// Token: 0x06012FF0 RID: 77808
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStructuredGridWriter_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012FF1 RID: 77809 RVA: 0x001AD0A0 File Offset: 0x001AB2A0
		public override int IsA(string type)
		{
			return vtkStructuredGridWriter.vtkStructuredGridWriter_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x06012FF2 RID: 77810
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStructuredGridWriter_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012FF3 RID: 77811 RVA: 0x001AD0C0 File Offset: 0x001AB2C0
		public new static int IsTypeOf(string type)
		{
			return vtkStructuredGridWriter.vtkStructuredGridWriter_IsTypeOf_07(type);
		}

		// Token: 0x06012FF4 RID: 77812
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStructuredGridWriter_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012FF5 RID: 77813 RVA: 0x001AD0DC File Offset: 0x001AB2DC
		public new vtkStructuredGridWriter NewInstance()
		{
			vtkStructuredGridWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStructuredGridWriter.vtkStructuredGridWriter_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStructuredGridWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06012FF6 RID: 77814
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStructuredGridWriter_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012FF7 RID: 77815 RVA: 0x001AD138 File Offset: 0x001AB338
		public new static vtkStructuredGridWriter SafeDownCast(vtkObjectBase o)
		{
			vtkStructuredGridWriter vtkStructuredGridWriter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStructuredGridWriter.vtkStructuredGridWriter_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStructuredGridWriter = (vtkStructuredGridWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStructuredGridWriter.Register(null);
				}
			}
			return vtkStructuredGridWriter;
		}

		// Token: 0x06012FF8 RID: 77816
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStructuredGridWriter_SetWriteExtent_11(HandleRef pThis, byte _arg);

		/// <summary>
		/// When WriteExtent is on, vtkStructuredPointsWriter writes
		/// data extent in the output file. Otherwise, it writes dimensions.
		/// The only time this option is useful is when the extents do
		/// not start at (0, 0, 0). This is an options to support writing
		/// of older formats while still using a newer VTK.
		/// </summary>
		// Token: 0x06012FF9 RID: 77817 RVA: 0x001AD1B7 File Offset: 0x001AB3B7
		public virtual void SetWriteExtent(bool _arg)
		{
			vtkStructuredGridWriter.vtkStructuredGridWriter_SetWriteExtent_11(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06012FFA RID: 77818
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStructuredGridWriter_WriteExtentOff_12(HandleRef pThis);

		/// <summary>
		/// When WriteExtent is on, vtkStructuredPointsWriter writes
		/// data extent in the output file. Otherwise, it writes dimensions.
		/// The only time this option is useful is when the extents do
		/// not start at (0, 0, 0). This is an options to support writing
		/// of older formats while still using a newer VTK.
		/// </summary>
		// Token: 0x06012FFB RID: 77819 RVA: 0x001AD1CF File Offset: 0x001AB3CF
		public virtual void WriteExtentOff()
		{
			vtkStructuredGridWriter.vtkStructuredGridWriter_WriteExtentOff_12(base.GetCppThis());
		}

		// Token: 0x06012FFC RID: 77820
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStructuredGridWriter_WriteExtentOn_13(HandleRef pThis);

		/// <summary>
		/// When WriteExtent is on, vtkStructuredPointsWriter writes
		/// data extent in the output file. Otherwise, it writes dimensions.
		/// The only time this option is useful is when the extents do
		/// not start at (0, 0, 0). This is an options to support writing
		/// of older formats while still using a newer VTK.
		/// </summary>
		// Token: 0x06012FFD RID: 77821 RVA: 0x001AD1DE File Offset: 0x001AB3DE
		public virtual void WriteExtentOn()
		{
			vtkStructuredGridWriter.vtkStructuredGridWriter_WriteExtentOn_13(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040015F2 RID: 5618
		public new const string MRFullTypeName = "Kitware.VTK.vtkStructuredGridWriter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040015F3 RID: 5619
		public new static readonly string MRClassNameKey = "class vtkStructuredGridWriter";
	}
}
