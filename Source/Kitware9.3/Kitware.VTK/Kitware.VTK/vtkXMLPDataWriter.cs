using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkXMLPDataWriter
	/// </summary>
	/// <remarks>
	///    Write data in a parallel XML format.
	///
	/// vtkXMLPDataWriter is the superclass for all XML parallel data set
	/// writers.  It provides functionality needed for writing parallel
	/// formats, such as the selection of which writer writes the summary
	/// file and what range of pieces are assigned to each serial writer.
	/// </remarks>
	// Token: 0x02000140 RID: 320
	public abstract class vtkXMLPDataWriter : vtkXMLPDataObjectWriter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06003EAF RID: 16047 RVA: 0x0005B8D5 File Offset: 0x00059AD5
		static vtkXMLPDataWriter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkXMLPDataWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLPDataWriter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06003EB0 RID: 16048 RVA: 0x0005B8FD File Offset: 0x00059AFD
		public vtkXMLPDataWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06003EB1 RID: 16049 RVA: 0x0005B90B File Offset: 0x00059B0B
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06003EB2 RID: 16050
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLPDataWriter_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003EB3 RID: 16051 RVA: 0x0005B918 File Offset: 0x00059B18
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkXMLPDataWriter.vtkXMLPDataWriter_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06003EB4 RID: 16052
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLPDataWriter_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003EB5 RID: 16053 RVA: 0x0005B938 File Offset: 0x00059B38
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkXMLPDataWriter.vtkXMLPDataWriter_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06003EB6 RID: 16054
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLPDataWriter_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003EB7 RID: 16055 RVA: 0x0005B954 File Offset: 0x00059B54
		public override int IsA(string type)
		{
			return vtkXMLPDataWriter.vtkXMLPDataWriter_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x06003EB8 RID: 16056
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLPDataWriter_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003EB9 RID: 16057 RVA: 0x0005B974 File Offset: 0x00059B74
		public new static int IsTypeOf(string type)
		{
			return vtkXMLPDataWriter.vtkXMLPDataWriter_IsTypeOf_04(type);
		}

		// Token: 0x06003EBA RID: 16058
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLPDataWriter_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003EBB RID: 16059 RVA: 0x0005B990 File Offset: 0x00059B90
		public new vtkXMLPDataWriter NewInstance()
		{
			vtkXMLPDataWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLPDataWriter.vtkXMLPDataWriter_NewInstance_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLPDataWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06003EBC RID: 16060
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLPDataWriter_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003EBD RID: 16061 RVA: 0x0005B9EC File Offset: 0x00059BEC
		public new static vtkXMLPDataWriter SafeDownCast(vtkObjectBase o)
		{
			vtkXMLPDataWriter vtkXMLPDataWriter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLPDataWriter.vtkXMLPDataWriter_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLPDataWriter = (vtkXMLPDataWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLPDataWriter.Register(null);
				}
			}
			return vtkXMLPDataWriter;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040006C4 RID: 1732
		public new const string MRFullTypeName = "Kitware.VTK.vtkXMLPDataWriter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040006C5 RID: 1733
		public new static readonly string MRClassNameKey = "class vtkXMLPDataWriter";
	}
}
