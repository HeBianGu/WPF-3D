using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkXMLDataSetWriter
	/// </summary>
	/// <remarks>
	///    Write any type of VTK XML file.
	///
	/// vtkXMLDataSetWriter is a wrapper around the VTK XML file format
	/// writers.  Given an input vtkDataSet, the correct writer is
	/// automatically selected based on the type of input.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkXMLImageDataWriter vtkXMLStructuredGridWriter
	/// vtkXMLRectilinearGridWriter vtkXMLPolyDataWriter
	/// vtkXMLUnstructuredGridWriter
	/// </seealso>
	// Token: 0x020006C6 RID: 1734
	public class vtkXMLDataSetWriter : vtkXMLDataObjectWriter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06012781 RID: 75649 RVA: 0x0019E17B File Offset: 0x0019C37B
		static vtkXMLDataSetWriter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkXMLDataSetWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLDataSetWriter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06012782 RID: 75650 RVA: 0x0019E1A3 File Offset: 0x0019C3A3
		public vtkXMLDataSetWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06012783 RID: 75651
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLDataSetWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012784 RID: 75652 RVA: 0x0019E1B4 File Offset: 0x0019C3B4
		public new static vtkXMLDataSetWriter New()
		{
			vtkXMLDataSetWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLDataSetWriter.vtkXMLDataSetWriter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLDataSetWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012785 RID: 75653 RVA: 0x0019E208 File Offset: 0x0019C408
		public vtkXMLDataSetWriter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkXMLDataSetWriter.vtkXMLDataSetWriter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06012786 RID: 75654 RVA: 0x0019E24C File Offset: 0x0019C44C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06012787 RID: 75655
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLDataSetWriter_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012788 RID: 75656 RVA: 0x0019E258 File Offset: 0x0019C458
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkXMLDataSetWriter.vtkXMLDataSetWriter_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06012789 RID: 75657
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLDataSetWriter_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601278A RID: 75658 RVA: 0x0019E278 File Offset: 0x0019C478
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkXMLDataSetWriter.vtkXMLDataSetWriter_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0601278B RID: 75659
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLDataSetWriter_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601278C RID: 75660 RVA: 0x0019E294 File Offset: 0x0019C494
		public override int IsA(string type)
		{
			return vtkXMLDataSetWriter.vtkXMLDataSetWriter_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x0601278D RID: 75661
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLDataSetWriter_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601278E RID: 75662 RVA: 0x0019E2B4 File Offset: 0x0019C4B4
		public new static int IsTypeOf(string type)
		{
			return vtkXMLDataSetWriter.vtkXMLDataSetWriter_IsTypeOf_04(type);
		}

		// Token: 0x0601278F RID: 75663
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLDataSetWriter_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012790 RID: 75664 RVA: 0x0019E2D0 File Offset: 0x0019C4D0
		public new vtkXMLDataSetWriter NewInstance()
		{
			vtkXMLDataSetWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLDataSetWriter.vtkXMLDataSetWriter_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLDataSetWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06012791 RID: 75665
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLDataSetWriter_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012792 RID: 75666 RVA: 0x0019E32C File Offset: 0x0019C52C
		public new static vtkXMLDataSetWriter SafeDownCast(vtkObjectBase o)
		{
			vtkXMLDataSetWriter vtkXMLDataSetWriter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLDataSetWriter.vtkXMLDataSetWriter_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLDataSetWriter = (vtkXMLDataSetWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLDataSetWriter.Register(null);
				}
			}
			return vtkXMLDataSetWriter;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400153D RID: 5437
		public new const string MRFullTypeName = "Kitware.VTK.vtkXMLDataSetWriter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400153E RID: 5438
		public new static readonly string MRClassNameKey = "class vtkXMLDataSetWriter";
	}
}
