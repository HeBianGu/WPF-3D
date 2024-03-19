using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkXGMLReader
	/// </summary>
	/// <remarks>
	///    Reads XGML graph files.
	/// This reader is developed for a simple graph file format based
	/// loosely on the "GML" notation.  This implementation is based
	/// heavily on the vtkTulipReader class that forms part of the
	/// Titan toolkit.
	///
	/// @par Thanks:
	/// Thanks to David Duke from the University of Leeds for providing this
	/// implementation.
	/// </remarks>
	// Token: 0x020001A8 RID: 424
	public class vtkXGMLReader : vtkUndirectedGraphAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600523C RID: 21052 RVA: 0x00077DD3 File Offset: 0x00075FD3
		static vtkXGMLReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkXGMLReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkXGMLReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600523D RID: 21053 RVA: 0x00077DFB File Offset: 0x00075FFB
		public vtkXGMLReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600523E RID: 21054
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXGMLReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600523F RID: 21055 RVA: 0x00077E0C File Offset: 0x0007600C
		public new static vtkXGMLReader New()
		{
			vtkXGMLReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXGMLReader.vtkXGMLReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXGMLReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005240 RID: 21056 RVA: 0x00077E60 File Offset: 0x00076060
		public vtkXGMLReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkXGMLReader.vtkXGMLReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06005241 RID: 21057 RVA: 0x00077EA4 File Offset: 0x000760A4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06005242 RID: 21058
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXGMLReader_GetFileName_01(HandleRef pThis);

		/// <summary>
		/// The XGML file name.
		/// </summary>
		// Token: 0x06005243 RID: 21059 RVA: 0x00077EB0 File Offset: 0x000760B0
		public virtual string GetFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkXGMLReader.vtkXGMLReader_GetFileName_01(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06005244 RID: 21060
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXGMLReader_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005245 RID: 21061 RVA: 0x00077EEC File Offset: 0x000760EC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkXGMLReader.vtkXGMLReader_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06005246 RID: 21062
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXGMLReader_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005247 RID: 21063 RVA: 0x00077F0C File Offset: 0x0007610C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkXGMLReader.vtkXGMLReader_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06005248 RID: 21064
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXGMLReader_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005249 RID: 21065 RVA: 0x00077F28 File Offset: 0x00076128
		public override int IsA(string type)
		{
			return vtkXGMLReader.vtkXGMLReader_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x0600524A RID: 21066
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXGMLReader_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600524B RID: 21067 RVA: 0x00077F48 File Offset: 0x00076148
		public new static int IsTypeOf(string type)
		{
			return vtkXGMLReader.vtkXGMLReader_IsTypeOf_05(type);
		}

		// Token: 0x0600524C RID: 21068
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXGMLReader_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600524D RID: 21069 RVA: 0x00077F64 File Offset: 0x00076164
		public new vtkXGMLReader NewInstance()
		{
			vtkXGMLReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXGMLReader.vtkXGMLReader_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXGMLReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600524E RID: 21070
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXGMLReader_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600524F RID: 21071 RVA: 0x00077FC0 File Offset: 0x000761C0
		public new static vtkXGMLReader SafeDownCast(vtkObjectBase o)
		{
			vtkXGMLReader vtkXGMLReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXGMLReader.vtkXGMLReader_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXGMLReader = (vtkXGMLReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXGMLReader.Register(null);
				}
			}
			return vtkXGMLReader;
		}

		// Token: 0x06005250 RID: 21072
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXGMLReader_SetFileName_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// The XGML file name.
		/// </summary>
		// Token: 0x06005251 RID: 21073 RVA: 0x0007803F File Offset: 0x0007623F
		public virtual void SetFileName(string _arg)
		{
			vtkXGMLReader.vtkXGMLReader_SetFileName_09(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040007B5 RID: 1973
		public new const string MRFullTypeName = "Kitware.VTK.vtkXGMLReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040007B6 RID: 1974
		public new static readonly string MRClassNameKey = "class vtkXGMLReader";
	}
}
