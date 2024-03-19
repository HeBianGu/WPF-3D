using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkXMLPDataSetWriter
	/// </summary>
	/// <remarks>
	///    Write any type of PVTK XML file.
	///
	/// vtkXMLPDataSetWriter is a wrapper around the PVTK XML file format
	/// writers.  Given an input vtkDataSet, the correct writer is
	/// automatically selected based on the type of input.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkXMLPImageDataWriter vtkXMLPStructuredGridWriter
	/// vtkXMLPRectilinearGridWriter vtkXMLPPolyDataWriter
	/// vtkXMLPUnstructuredGridWriter
	/// </seealso>
	// Token: 0x02000141 RID: 321
	public class vtkXMLPDataSetWriter : vtkXMLPDataWriter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06003EBE RID: 16062 RVA: 0x0005BA6B File Offset: 0x00059C6B
		static vtkXMLPDataSetWriter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkXMLPDataSetWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLPDataSetWriter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06003EBF RID: 16063 RVA: 0x0005BA93 File Offset: 0x00059C93
		public vtkXMLPDataSetWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06003EC0 RID: 16064
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLPDataSetWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003EC1 RID: 16065 RVA: 0x0005BAA4 File Offset: 0x00059CA4
		public new static vtkXMLPDataSetWriter New()
		{
			vtkXMLPDataSetWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLPDataSetWriter.vtkXMLPDataSetWriter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLPDataSetWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003EC2 RID: 16066 RVA: 0x0005BAF8 File Offset: 0x00059CF8
		public vtkXMLPDataSetWriter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkXMLPDataSetWriter.vtkXMLPDataSetWriter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06003EC3 RID: 16067 RVA: 0x0005BB3C File Offset: 0x00059D3C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06003EC4 RID: 16068
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLPDataSetWriter_GetInput_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get/Set the writer's input.
		/// </summary>
		// Token: 0x06003EC5 RID: 16069 RVA: 0x0005BB48 File Offset: 0x00059D48
		public new vtkDataSet GetInput()
		{
			vtkDataSet vtkDataSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLPDataSetWriter.vtkXMLPDataSetWriter_GetInput_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06003EC6 RID: 16070
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLPDataSetWriter_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003EC7 RID: 16071 RVA: 0x0005BBB8 File Offset: 0x00059DB8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkXMLPDataSetWriter.vtkXMLPDataSetWriter_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06003EC8 RID: 16072
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLPDataSetWriter_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003EC9 RID: 16073 RVA: 0x0005BBD8 File Offset: 0x00059DD8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkXMLPDataSetWriter.vtkXMLPDataSetWriter_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06003ECA RID: 16074
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLPDataSetWriter_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003ECB RID: 16075 RVA: 0x0005BBF4 File Offset: 0x00059DF4
		public override int IsA(string type)
		{
			return vtkXMLPDataSetWriter.vtkXMLPDataSetWriter_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x06003ECC RID: 16076
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLPDataSetWriter_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003ECD RID: 16077 RVA: 0x0005BC14 File Offset: 0x00059E14
		public new static int IsTypeOf(string type)
		{
			return vtkXMLPDataSetWriter.vtkXMLPDataSetWriter_IsTypeOf_05(type);
		}

		// Token: 0x06003ECE RID: 16078
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLPDataSetWriter_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003ECF RID: 16079 RVA: 0x0005BC30 File Offset: 0x00059E30
		public new vtkXMLPDataSetWriter NewInstance()
		{
			vtkXMLPDataSetWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLPDataSetWriter.vtkXMLPDataSetWriter_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLPDataSetWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06003ED0 RID: 16080
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLPDataSetWriter_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003ED1 RID: 16081 RVA: 0x0005BC8C File Offset: 0x00059E8C
		public new static vtkXMLPDataSetWriter SafeDownCast(vtkObjectBase o)
		{
			vtkXMLPDataSetWriter vtkXMLPDataSetWriter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLPDataSetWriter.vtkXMLPDataSetWriter_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLPDataSetWriter = (vtkXMLPDataSetWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLPDataSetWriter.Register(null);
				}
			}
			return vtkXMLPDataSetWriter;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040006C6 RID: 1734
		public new const string MRFullTypeName = "Kitware.VTK.vtkXMLPDataSetWriter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040006C7 RID: 1735
		public new static readonly string MRClassNameKey = "class vtkXMLPDataSetWriter";
	}
}
