using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkXMLDataObjectWriter
	/// </summary>
	/// <remarks>
	///    Write any type of VTK XML file.
	///
	/// vtkXMLDataObjectWriter is a wrapper around the VTK XML file format
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
	// Token: 0x020006C4 RID: 1732
	public class vtkXMLDataObjectWriter : vtkXMLWriter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06012756 RID: 75606 RVA: 0x0019DC6B File Offset: 0x0019BE6B
		static vtkXMLDataObjectWriter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkXMLDataObjectWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLDataObjectWriter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06012757 RID: 75607 RVA: 0x0019DC93 File Offset: 0x0019BE93
		public vtkXMLDataObjectWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06012758 RID: 75608
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLDataObjectWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012759 RID: 75609 RVA: 0x0019DCA4 File Offset: 0x0019BEA4
		public new static vtkXMLDataObjectWriter New()
		{
			vtkXMLDataObjectWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLDataObjectWriter.vtkXMLDataObjectWriter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLDataObjectWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601275A RID: 75610 RVA: 0x0019DCF8 File Offset: 0x0019BEF8
		public vtkXMLDataObjectWriter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkXMLDataObjectWriter.vtkXMLDataObjectWriter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601275B RID: 75611 RVA: 0x0019DD3C File Offset: 0x0019BF3C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601275C RID: 75612
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLDataObjectWriter_GetInput_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get/Set the writer's input.
		/// </summary>
		// Token: 0x0601275D RID: 75613 RVA: 0x0019DD48 File Offset: 0x0019BF48
		public new vtkDataSet GetInput()
		{
			vtkDataSet vtkDataSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLDataObjectWriter.vtkXMLDataObjectWriter_GetInput_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataSet = (vtkDataSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataSet.Register(null);
				}
			}
			return vtkDataSet;
		}

		// Token: 0x0601275E RID: 75614
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLDataObjectWriter_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601275F RID: 75615 RVA: 0x0019DDB8 File Offset: 0x0019BFB8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkXMLDataObjectWriter.vtkXMLDataObjectWriter_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06012760 RID: 75616
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLDataObjectWriter_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012761 RID: 75617 RVA: 0x0019DDD8 File Offset: 0x0019BFD8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkXMLDataObjectWriter.vtkXMLDataObjectWriter_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06012762 RID: 75618
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLDataObjectWriter_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012763 RID: 75619 RVA: 0x0019DDF4 File Offset: 0x0019BFF4
		public override int IsA(string type)
		{
			return vtkXMLDataObjectWriter.vtkXMLDataObjectWriter_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x06012764 RID: 75620
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLDataObjectWriter_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012765 RID: 75621 RVA: 0x0019DE14 File Offset: 0x0019C014
		public new static int IsTypeOf(string type)
		{
			return vtkXMLDataObjectWriter.vtkXMLDataObjectWriter_IsTypeOf_05(type);
		}

		// Token: 0x06012766 RID: 75622
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLDataObjectWriter_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012767 RID: 75623 RVA: 0x0019DE30 File Offset: 0x0019C030
		public new vtkXMLDataObjectWriter NewInstance()
		{
			vtkXMLDataObjectWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLDataObjectWriter.vtkXMLDataObjectWriter_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLDataObjectWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06012768 RID: 75624
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLDataObjectWriter_NewWriter_08(int dataset_type, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Creates a writer for the given dataset type. May return nullptr for
		/// unsupported/unrecognized dataset types. Returns a new instance. The caller
		/// is responsible of calling vtkObject::Delete() or vtkObject::UnRegister() on
		/// it when done.
		/// </summary>
		// Token: 0x06012769 RID: 75625 RVA: 0x0019DE8C File Offset: 0x0019C08C
		public static vtkXMLWriter NewWriter(int dataset_type)
		{
			vtkXMLWriter vtkXMLWriter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLDataObjectWriter.vtkXMLDataObjectWriter_NewWriter_08(dataset_type, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLWriter = (vtkXMLWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLWriter.Register(null);
				}
			}
			return vtkXMLWriter;
		}

		// Token: 0x0601276A RID: 75626
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLDataObjectWriter_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601276B RID: 75627 RVA: 0x0019DEF8 File Offset: 0x0019C0F8
		public new static vtkXMLDataObjectWriter SafeDownCast(vtkObjectBase o)
		{
			vtkXMLDataObjectWriter vtkXMLDataObjectWriter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLDataObjectWriter.vtkXMLDataObjectWriter_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLDataObjectWriter = (vtkXMLDataObjectWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLDataObjectWriter.Register(null);
				}
			}
			return vtkXMLDataObjectWriter;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001539 RID: 5433
		public new const string MRFullTypeName = "Kitware.VTK.vtkXMLDataObjectWriter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400153A RID: 5434
		public new static readonly string MRClassNameKey = "class vtkXMLDataObjectWriter";
	}
}
