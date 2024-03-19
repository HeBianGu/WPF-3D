using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkOBJReader
	/// </summary>
	/// <remarks>
	///    read Wavefront .obj files
	///
	/// vtkOBJReader is a source object that reads Wavefront .obj
	/// files. The output of this source object is polygonal data.
	/// </remarks>
	/// <seealso>
	///
	/// vtkOBJImporter
	/// </seealso>
	// Token: 0x0200020B RID: 523
	public class vtkOBJReader : vtkAbstractPolyDataReader
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06006412 RID: 25618 RVA: 0x0008FFA1 File Offset: 0x0008E1A1
		static vtkOBJReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOBJReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOBJReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06006413 RID: 25619 RVA: 0x0008FFC9 File Offset: 0x0008E1C9
		public vtkOBJReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06006414 RID: 25620
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOBJReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006415 RID: 25621 RVA: 0x0008FFD8 File Offset: 0x0008E1D8
		public new static vtkOBJReader New()
		{
			vtkOBJReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOBJReader.vtkOBJReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOBJReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006416 RID: 25622 RVA: 0x0009002C File Offset: 0x0008E22C
		public vtkOBJReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkOBJReader.vtkOBJReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06006417 RID: 25623 RVA: 0x00090070 File Offset: 0x0008E270
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06006418 RID: 25624
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOBJReader_GetComment_01(HandleRef pThis);

		/// <summary>
		/// Get first comment in the file.
		/// Comment may be multiple lines. # and leading spaces are removed.
		/// </summary>
		// Token: 0x06006419 RID: 25625 RVA: 0x0009007C File Offset: 0x0008E27C
		public virtual string GetComment()
		{
			string s = Marshal.PtrToStringAnsi(vtkOBJReader.vtkOBJReader_GetComment_01(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600641A RID: 25626
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOBJReader_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600641B RID: 25627 RVA: 0x000900B8 File Offset: 0x0008E2B8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkOBJReader.vtkOBJReader_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0600641C RID: 25628
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOBJReader_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600641D RID: 25629 RVA: 0x000900D8 File Offset: 0x0008E2D8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkOBJReader.vtkOBJReader_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0600641E RID: 25630
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOBJReader_GetStream_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify stream to read from
		/// When selecting input method, `Stream` has an higher priority than `Filename`.
		/// If both are null, reader outputs nothing.
		/// </summary>
		// Token: 0x0600641F RID: 25631 RVA: 0x000900F4 File Offset: 0x0008E2F4
		public virtual vtkResourceStream GetStream()
		{
			vtkResourceStream vtkResourceStream = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOBJReader.vtkOBJReader_GetStream_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkResourceStream = (vtkResourceStream)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkResourceStream.Register(null);
				}
			}
			return vtkResourceStream;
		}

		// Token: 0x06006420 RID: 25632
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOBJReader_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006421 RID: 25633 RVA: 0x00090164 File Offset: 0x0008E364
		public override int IsA(string type)
		{
			return vtkOBJReader.vtkOBJReader_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x06006422 RID: 25634
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOBJReader_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006423 RID: 25635 RVA: 0x00090184 File Offset: 0x0008E384
		public new static int IsTypeOf(string type)
		{
			return vtkOBJReader.vtkOBJReader_IsTypeOf_06(type);
		}

		// Token: 0x06006424 RID: 25636
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOBJReader_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006425 RID: 25637 RVA: 0x000901A0 File Offset: 0x0008E3A0
		public new vtkOBJReader NewInstance()
		{
			vtkOBJReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOBJReader.vtkOBJReader_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOBJReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06006426 RID: 25638
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOBJReader_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006427 RID: 25639 RVA: 0x000901FC File Offset: 0x0008E3FC
		public new static vtkOBJReader SafeDownCast(vtkObjectBase o)
		{
			vtkOBJReader vtkOBJReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOBJReader.vtkOBJReader_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOBJReader = (vtkOBJReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOBJReader.Register(null);
				}
			}
			return vtkOBJReader;
		}

		// Token: 0x06006428 RID: 25640
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOBJReader_SetStream_10(HandleRef pThis, HandleRef _arg);

		/// <summary>
		/// Specify stream to read from
		/// When selecting input method, `Stream` has an higher priority than `Filename`.
		/// If both are null, reader outputs nothing.
		/// </summary>
		// Token: 0x06006429 RID: 25641 RVA: 0x0009027C File Offset: 0x0008E47C
		public virtual void SetStream(vtkResourceStream _arg)
		{
			vtkOBJReader.vtkOBJReader_SetStream_10(base.GetCppThis(), (_arg == null) ? default(HandleRef) : _arg.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040008ED RID: 2285
		public new const string MRFullTypeName = "Kitware.VTK.vtkOBJReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040008EE RID: 2286
		public new static readonly string MRClassNameKey = "class vtkOBJReader";
	}
}
