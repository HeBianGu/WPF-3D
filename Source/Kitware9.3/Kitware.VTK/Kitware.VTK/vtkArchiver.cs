using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkArchiver
	/// </summary>
	/// <remarks>
	///    Writes an archive
	///
	/// vtkArchiver is a base class for constructing an archive. The default
	/// implementation constructs a directory at the location of the ArchiveName
	/// and populates it with files and directories as requested by Insert().
	/// Classes that derive from vtkArchiver can customize the output using such
	/// features as compression, in-memory serialization and third-party archival
	/// tools.
	/// </remarks>
	// Token: 0x02000B3D RID: 2877
	public class vtkArchiver : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601E194 RID: 123284 RVA: 0x002A933B File Offset: 0x002A753B
		static vtkArchiver()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkArchiver.MRClassNameKey, Type.GetType("Kitware.VTK.vtkArchiver"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601E195 RID: 123285 RVA: 0x002A9363 File Offset: 0x002A7563
		public vtkArchiver(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601E196 RID: 123286
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkArchiver_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E197 RID: 123287 RVA: 0x002A9374 File Offset: 0x002A7574
		public new static vtkArchiver New()
		{
			vtkArchiver result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkArchiver.vtkArchiver_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkArchiver)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E198 RID: 123288 RVA: 0x002A93C8 File Offset: 0x002A75C8
		public vtkArchiver() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkArchiver.vtkArchiver_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601E199 RID: 123289 RVA: 0x002A940C File Offset: 0x002A760C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601E19A RID: 123290
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArchiver_CloseArchive_01(HandleRef pThis);

		/// <summary>
		/// Close the archive.
		/// </summary>
		// Token: 0x0601E19B RID: 123291 RVA: 0x002A9417 File Offset: 0x002A7617
		public virtual void CloseArchive()
		{
			vtkArchiver.vtkArchiver_CloseArchive_01(base.GetCppThis());
		}

		// Token: 0x0601E19C RID: 123292
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkArchiver_Contains_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string relativePath);

		/// <summary>
		/// Checks if \p relativePath represents an entry in the archive.
		/// </summary>
		// Token: 0x0601E19D RID: 123293 RVA: 0x002A9428 File Offset: 0x002A7628
		public virtual bool Contains(string relativePath)
		{
			return vtkArchiver.vtkArchiver_Contains_02(base.GetCppThis(), relativePath) != 0;
		}

		// Token: 0x0601E19E RID: 123294
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkArchiver_GetArchiveName_03(HandleRef pThis);

		/// <summary>
		/// Specify the name of the archive to generate.
		/// </summary>
		// Token: 0x0601E19F RID: 123295 RVA: 0x002A9450 File Offset: 0x002A7650
		public virtual string GetArchiveName()
		{
			string s = Marshal.PtrToStringAnsi(vtkArchiver.vtkArchiver_GetArchiveName_03(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0601E1A0 RID: 123296
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkArchiver_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E1A1 RID: 123297 RVA: 0x002A948C File Offset: 0x002A768C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkArchiver.vtkArchiver_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x0601E1A2 RID: 123298
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkArchiver_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E1A3 RID: 123299 RVA: 0x002A94AC File Offset: 0x002A76AC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkArchiver.vtkArchiver_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x0601E1A4 RID: 123300
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArchiver_InsertIntoArchive_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string relativePath, [MarshalAs(UnmanagedType.LPUTF8Str)] string data, ulong size);

		/// <summary>
		/// Insert \p data of size \p size into the archive at \p relativePath.
		/// </summary>
		// Token: 0x0601E1A5 RID: 123301 RVA: 0x002A94C6 File Offset: 0x002A76C6
		public virtual void InsertIntoArchive(string relativePath, string data, ulong size)
		{
			vtkArchiver.vtkArchiver_InsertIntoArchive_06(base.GetCppThis(), relativePath, data, size);
		}

		// Token: 0x0601E1A6 RID: 123302
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkArchiver_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E1A7 RID: 123303 RVA: 0x002A94D8 File Offset: 0x002A76D8
		public override int IsA(string type)
		{
			return vtkArchiver.vtkArchiver_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x0601E1A8 RID: 123304
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkArchiver_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E1A9 RID: 123305 RVA: 0x002A94F8 File Offset: 0x002A76F8
		public new static int IsTypeOf(string type)
		{
			return vtkArchiver.vtkArchiver_IsTypeOf_08(type);
		}

		// Token: 0x0601E1AA RID: 123306
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkArchiver_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E1AB RID: 123307 RVA: 0x002A9514 File Offset: 0x002A7714
		public new vtkArchiver NewInstance()
		{
			vtkArchiver result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkArchiver.vtkArchiver_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkArchiver)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601E1AC RID: 123308
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArchiver_OpenArchive_11(HandleRef pThis);

		/// <summary>
		/// Open the archive for writing.
		/// </summary>
		// Token: 0x0601E1AD RID: 123309 RVA: 0x002A956E File Offset: 0x002A776E
		public virtual void OpenArchive()
		{
			vtkArchiver.vtkArchiver_OpenArchive_11(base.GetCppThis());
		}

		// Token: 0x0601E1AE RID: 123310
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkArchiver_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E1AF RID: 123311 RVA: 0x002A9580 File Offset: 0x002A7780
		public new static vtkArchiver SafeDownCast(vtkObjectBase o)
		{
			vtkArchiver vtkArchiver = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkArchiver.vtkArchiver_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkArchiver = (vtkArchiver)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkArchiver.Register(null);
				}
			}
			return vtkArchiver;
		}

		// Token: 0x0601E1B0 RID: 123312
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArchiver_SetArchiveName_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Specify the name of the archive to generate.
		/// </summary>
		// Token: 0x0601E1B1 RID: 123313 RVA: 0x002A95FF File Offset: 0x002A77FF
		public virtual void SetArchiveName(string _arg)
		{
			vtkArchiver.vtkArchiver_SetArchiveName_13(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001FC9 RID: 8137
		public new const string MRFullTypeName = "Kitware.VTK.vtkArchiver";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001FCA RID: 8138
		public new static readonly string MRClassNameKey = "class vtkArchiver";
	}
}
