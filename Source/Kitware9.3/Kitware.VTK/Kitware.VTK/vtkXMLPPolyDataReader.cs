using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkXMLPPolyDataReader
	/// </summary>
	/// <remarks>
	///    Read PVTK XML PolyData files.
	///
	/// vtkXMLPPolyDataReader reads the PVTK XML PolyData file format.
	/// This reads the parallel format's summary file and then uses
	/// vtkXMLPolyDataReader to read data from the individual PolyData
	/// piece files.  Streaming is supported.  The standard extension for
	/// this reader's file format is "pvtp".
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkXMLPolyDataReader
	/// </seealso>
	// Token: 0x020006D8 RID: 1752
	public class vtkXMLPPolyDataReader : vtkXMLPUnstructuredDataReader
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06012905 RID: 76037 RVA: 0x001A0C57 File Offset: 0x0019EE57
		static vtkXMLPPolyDataReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkXMLPPolyDataReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLPPolyDataReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06012906 RID: 76038 RVA: 0x001A0C7F File Offset: 0x0019EE7F
		public vtkXMLPPolyDataReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06012907 RID: 76039
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLPPolyDataReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012908 RID: 76040 RVA: 0x001A0C90 File Offset: 0x0019EE90
		public new static vtkXMLPPolyDataReader New()
		{
			vtkXMLPPolyDataReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLPPolyDataReader.vtkXMLPPolyDataReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLPPolyDataReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012909 RID: 76041 RVA: 0x001A0CE4 File Offset: 0x0019EEE4
		public vtkXMLPPolyDataReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkXMLPPolyDataReader.vtkXMLPPolyDataReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601290A RID: 76042 RVA: 0x001A0D28 File Offset: 0x0019EF28
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601290B RID: 76043
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLPPolyDataReader_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601290C RID: 76044 RVA: 0x001A0D34 File Offset: 0x0019EF34
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkXMLPPolyDataReader.vtkXMLPPolyDataReader_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0601290D RID: 76045
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLPPolyDataReader_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601290E RID: 76046 RVA: 0x001A0D54 File Offset: 0x0019EF54
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkXMLPPolyDataReader.vtkXMLPPolyDataReader_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0601290F RID: 76047
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLPPolyDataReader_GetOutput_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the reader's output.
		/// </summary>
		// Token: 0x06012910 RID: 76048 RVA: 0x001A0D70 File Offset: 0x0019EF70
		public vtkPolyData GetOutput()
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLPPolyDataReader.vtkXMLPPolyDataReader_GetOutput_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyData = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyData.Register(null);
				}
			}
			return vtkPolyData;
		}

		// Token: 0x06012911 RID: 76049
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLPPolyDataReader_GetOutput_04(HandleRef pThis, int idx, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the reader's output.
		/// </summary>
		// Token: 0x06012912 RID: 76050 RVA: 0x001A0DE0 File Offset: 0x0019EFE0
		public vtkPolyData GetOutput(int idx)
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLPPolyDataReader.vtkXMLPPolyDataReader_GetOutput_04(base.GetCppThis(), idx, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyData = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyData.Register(null);
				}
			}
			return vtkPolyData;
		}

		// Token: 0x06012913 RID: 76051
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLPPolyDataReader_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012914 RID: 76052 RVA: 0x001A0E50 File Offset: 0x0019F050
		public override int IsA(string type)
		{
			return vtkXMLPPolyDataReader.vtkXMLPPolyDataReader_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x06012915 RID: 76053
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLPPolyDataReader_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012916 RID: 76054 RVA: 0x001A0E70 File Offset: 0x0019F070
		public new static int IsTypeOf(string type)
		{
			return vtkXMLPPolyDataReader.vtkXMLPPolyDataReader_IsTypeOf_06(type);
		}

		// Token: 0x06012917 RID: 76055
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLPPolyDataReader_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012918 RID: 76056 RVA: 0x001A0E8C File Offset: 0x0019F08C
		public new vtkXMLPPolyDataReader NewInstance()
		{
			vtkXMLPPolyDataReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLPPolyDataReader.vtkXMLPPolyDataReader_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLPPolyDataReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06012919 RID: 76057
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLPPolyDataReader_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601291A RID: 76058 RVA: 0x001A0EE8 File Offset: 0x0019F0E8
		public new static vtkXMLPPolyDataReader SafeDownCast(vtkObjectBase o)
		{
			vtkXMLPPolyDataReader vtkXMLPPolyDataReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLPPolyDataReader.vtkXMLPPolyDataReader_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLPPolyDataReader = (vtkXMLPPolyDataReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLPPolyDataReader.Register(null);
				}
			}
			return vtkXMLPPolyDataReader;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001561 RID: 5473
		public new const string MRFullTypeName = "Kitware.VTK.vtkXMLPPolyDataReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001562 RID: 5474
		public new static readonly string MRClassNameKey = "class vtkXMLPPolyDataReader";
	}
}
