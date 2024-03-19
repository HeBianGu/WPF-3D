using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkFacetWriter
	/// </summary>
	/// <remarks>
	///    reads a dataset in Facet format
	///
	/// vtkFacetWriter creates an unstructured grid dataset. It reads ASCII files
	/// stored in Facet format
	///
	/// The facet format looks like this:
	/// FACET FILE ...
	/// nparts
	/// Part 1 name
	/// 0
	/// npoints 0 0
	/// p1x p1y p1z
	/// p2x p2y p2z
	/// ...
	/// 1
	/// Part 1 name
	/// ncells npointspercell
	/// p1c1 p2c1 p3c1 ... pnc1 materialnum partnum
	/// p1c2 p2c2 p3c2 ... pnc2 materialnum partnum
	/// ...
	/// </remarks>
	// Token: 0x020001FD RID: 509
	public class vtkFacetWriter : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600621A RID: 25114 RVA: 0x0008D341 File Offset: 0x0008B541
		static vtkFacetWriter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkFacetWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkFacetWriter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600621B RID: 25115 RVA: 0x0008D369 File Offset: 0x0008B569
		public vtkFacetWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600621C RID: 25116
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFacetWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600621D RID: 25117 RVA: 0x0008D378 File Offset: 0x0008B578
		public new static vtkFacetWriter New()
		{
			vtkFacetWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFacetWriter.vtkFacetWriter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFacetWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600621E RID: 25118 RVA: 0x0008D3CC File Offset: 0x0008B5CC
		public vtkFacetWriter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkFacetWriter.vtkFacetWriter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600621F RID: 25119 RVA: 0x0008D410 File Offset: 0x0008B610
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06006220 RID: 25120
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFacetWriter_GetFileName_01(HandleRef pThis);

		/// <summary>
		/// Specify file name of Facet datafile to read
		/// </summary>
		// Token: 0x06006221 RID: 25121 RVA: 0x0008D41C File Offset: 0x0008B61C
		public virtual string GetFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkFacetWriter.vtkFacetWriter_GetFileName_01(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06006222 RID: 25122
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkFacetWriter_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006223 RID: 25123 RVA: 0x0008D458 File Offset: 0x0008B658
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkFacetWriter.vtkFacetWriter_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06006224 RID: 25124
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkFacetWriter_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006225 RID: 25125 RVA: 0x0008D478 File Offset: 0x0008B678
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkFacetWriter.vtkFacetWriter_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06006226 RID: 25126
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFacetWriter_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006227 RID: 25127 RVA: 0x0008D494 File Offset: 0x0008B694
		public override int IsA(string type)
		{
			return vtkFacetWriter.vtkFacetWriter_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x06006228 RID: 25128
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFacetWriter_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006229 RID: 25129 RVA: 0x0008D4B4 File Offset: 0x0008B6B4
		public new static int IsTypeOf(string type)
		{
			return vtkFacetWriter.vtkFacetWriter_IsTypeOf_05(type);
		}

		// Token: 0x0600622A RID: 25130
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFacetWriter_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600622B RID: 25131 RVA: 0x0008D4D0 File Offset: 0x0008B6D0
		public new vtkFacetWriter NewInstance()
		{
			vtkFacetWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFacetWriter.vtkFacetWriter_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFacetWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600622C RID: 25132
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFacetWriter_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600622D RID: 25133 RVA: 0x0008D52C File Offset: 0x0008B72C
		public new static vtkFacetWriter SafeDownCast(vtkObjectBase o)
		{
			vtkFacetWriter vtkFacetWriter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFacetWriter.vtkFacetWriter_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFacetWriter = (vtkFacetWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFacetWriter.Register(null);
				}
			}
			return vtkFacetWriter;
		}

		// Token: 0x0600622E RID: 25134
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFacetWriter_SetFileName_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Specify file name of Facet datafile to read
		/// </summary>
		// Token: 0x0600622F RID: 25135 RVA: 0x0008D5AB File Offset: 0x0008B7AB
		public virtual void SetFileName(string _arg)
		{
			vtkFacetWriter.vtkFacetWriter_SetFileName_09(base.GetCppThis(), _arg);
		}

		// Token: 0x06006230 RID: 25136
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFacetWriter_Write_10(HandleRef pThis);

		/// <summary>
		/// Write data
		/// </summary>
		// Token: 0x06006231 RID: 25137 RVA: 0x0008D5BB File Offset: 0x0008B7BB
		public void Write()
		{
			vtkFacetWriter.vtkFacetWriter_Write_10(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040008C4 RID: 2244
		public new const string MRFullTypeName = "Kitware.VTK.vtkFacetWriter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040008C5 RID: 2245
		public new static readonly string MRClassNameKey = "class vtkFacetWriter";
	}
}
