using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkVASPTessellationReader
	/// </summary>
	/// <remarks>
	///    Read NPT_Z_TESSELLATE.out files.
	///
	///
	/// Read NPT_Z_TESSELLATE.out files from VASP.
	/// </remarks>
	// Token: 0x020001D2 RID: 466
	public class vtkVASPTessellationReader : vtkMoleculeAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060059C6 RID: 22982 RVA: 0x00081CCF File Offset: 0x0007FECF
		static vtkVASPTessellationReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkVASPTessellationReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkVASPTessellationReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060059C7 RID: 22983 RVA: 0x00081CF7 File Offset: 0x0007FEF7
		public vtkVASPTessellationReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060059C8 RID: 22984
		[DllImport("Kitware.VTK.IOChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVASPTessellationReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060059C9 RID: 22985 RVA: 0x00081D08 File Offset: 0x0007FF08
		public new static vtkVASPTessellationReader New()
		{
			vtkVASPTessellationReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVASPTessellationReader.vtkVASPTessellationReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVASPTessellationReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060059CA RID: 22986 RVA: 0x00081D5C File Offset: 0x0007FF5C
		public vtkVASPTessellationReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkVASPTessellationReader.vtkVASPTessellationReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060059CB RID: 22987 RVA: 0x00081DA0 File Offset: 0x0007FFA0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060059CC RID: 22988
		[DllImport("Kitware.VTK.IOChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVASPTessellationReader_GetFileName_01(HandleRef pThis);

		/// <summary>
		/// The name of the file to read.
		/// </summary>
		// Token: 0x060059CD RID: 22989 RVA: 0x00081DAC File Offset: 0x0007FFAC
		public virtual string GetFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkVASPTessellationReader.vtkVASPTessellationReader_GetFileName_01(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060059CE RID: 22990
		[DllImport("Kitware.VTK.IOChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVASPTessellationReader_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060059CF RID: 22991 RVA: 0x00081DE8 File Offset: 0x0007FFE8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkVASPTessellationReader.vtkVASPTessellationReader_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x060059D0 RID: 22992
		[DllImport("Kitware.VTK.IOChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVASPTessellationReader_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060059D1 RID: 22993 RVA: 0x00081E08 File Offset: 0x00080008
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkVASPTessellationReader.vtkVASPTessellationReader_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x060059D2 RID: 22994
		[DllImport("Kitware.VTK.IOChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVASPTessellationReader_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060059D3 RID: 22995 RVA: 0x00081E24 File Offset: 0x00080024
		public override int IsA(string type)
		{
			return vtkVASPTessellationReader.vtkVASPTessellationReader_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x060059D4 RID: 22996
		[DllImport("Kitware.VTK.IOChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVASPTessellationReader_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060059D5 RID: 22997 RVA: 0x00081E44 File Offset: 0x00080044
		public new static int IsTypeOf(string type)
		{
			return vtkVASPTessellationReader.vtkVASPTessellationReader_IsTypeOf_05(type);
		}

		// Token: 0x060059D6 RID: 22998
		[DllImport("Kitware.VTK.IOChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVASPTessellationReader_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060059D7 RID: 22999 RVA: 0x00081E60 File Offset: 0x00080060
		public new vtkVASPTessellationReader NewInstance()
		{
			vtkVASPTessellationReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVASPTessellationReader.vtkVASPTessellationReader_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVASPTessellationReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060059D8 RID: 23000
		[DllImport("Kitware.VTK.IOChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVASPTessellationReader_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060059D9 RID: 23001 RVA: 0x00081EBC File Offset: 0x000800BC
		public new static vtkVASPTessellationReader SafeDownCast(vtkObjectBase o)
		{
			vtkVASPTessellationReader vtkVASPTessellationReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVASPTessellationReader.vtkVASPTessellationReader_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkVASPTessellationReader = (vtkVASPTessellationReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkVASPTessellationReader.Register(null);
				}
			}
			return vtkVASPTessellationReader;
		}

		// Token: 0x060059DA RID: 23002
		[DllImport("Kitware.VTK.IOChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVASPTessellationReader_SetFileName_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// The name of the file to read.
		/// </summary>
		// Token: 0x060059DB RID: 23003 RVA: 0x00081F3B File Offset: 0x0008013B
		public virtual void SetFileName(string _arg)
		{
			vtkVASPTessellationReader.vtkVASPTessellationReader_SetFileName_09(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400086B RID: 2155
		public new const string MRFullTypeName = "Kitware.VTK.vtkVASPTessellationReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400086C RID: 2156
		public new static readonly string MRClassNameKey = "class vtkVASPTessellationReader";
	}
}
